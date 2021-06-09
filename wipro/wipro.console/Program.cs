using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Timers;
using wipro.console.Clients;
using wipro.core.DTO;
using System.Linq;
using wipro.core.Interface.Service;
using Microsoft.Extensions.DependencyInjection;
using wipro.core.Service;
using wipro.core;
using wipro.core.Data.Context;
using CsvHelper.TypeConversion;

namespace wipro.console
{
    class Program
    {
        private static readonly Timer _timerFila;
        private static ApiClient _apiClient;
        private static IMoedaService _moedaService;

        private static List<DadosMoedaDTO> CSVMoedas;
        private static List<DadosCotacaoDTO> CSVCotacao;
        private static List<MoedaDTO> dbMoedas;
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _moedaService = serviceProvider.GetService<IMoedaService>();
            _apiClient = new ApiClient();

            //Cria as listas de consulta
            CSVMoedas = RetornaCSV_DadosMoeda();
            CSVCotacao = RetornaCSV_DadosCotacao();
            dbMoedas = _moedaService.GetAllRegisters();

            ConfiguraTimer(_timerFila, 120);

            Console.ReadLine();
        }

        public static void ConfigureService(IServiceCollection services)
        {
            services.AddDbContext<wpContext>();
            InjetorDependencias.Registrar(services);
        }

        private static void ConfiguraTimer(Timer timer, int segundos)
        {
            timer = new Timer(segundos * 1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                var procDTO = _apiClient.GetProcessosAsync().Result;

                if (procDTO != null)
                { 
                    ProcessaRegistro(procDTO);

                    Console.WriteLine($"Executado : {DateTime.Now.ToLongDateString()} " +
                        $"Processado : Moeda={procDTO.Moeda} | " +
                        $"Data_Inicio={procDTO.Data_Inicio.ToShortDateString()} | " +
                        $"Data_Fim={procDTO.Data_Fim.ToShortDateString()}");
                }
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Executado : {DateTime.Now.ToLongDateString()} " +
                        ex.Message);
            }
        }

        private static void ProcessaRegistro(ProcessoDTO processoDTO)
        {

            //Filtrar os dados da moeda = Periodo e Moeda correspondente 
            List<DadosMoedaDTO> listaSaida = CSVMoedas.Where(x => x.Id_Moeda == processoDTO.Moeda && x.Data_Ref >= processoDTO.Data_Inicio && x.Data_Ref <= processoDTO.Data_Fim).ToList();

            //Relacionar os dados de cotação por DATA=DATA e MOEDA=IdMoeda
            listaSaida.ForEach(x =>
            {
                var idMoeda = dbMoedas.Where(db => db.Simbolo == x.Id_Moeda)
                    .FirstOrDefault().Id;
                
                x.Vlr_Cotacao = CSVCotacao.FirstOrDefault(t => t.Dat_Cotacao == x.Data_Ref &&
                    t.Cod_Cotacao == idMoeda).Vlr_Cotacao;
            });

            Salvar_Resultado(listaSaida);
        }

        private static List<DadosMoedaDTO> RetornaCSV_DadosMoeda()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                HeaderValidated = null,
                MissingFieldFound = null
            };
            var path = Directory.GetCurrentDirectory() + @"\Arquivos\DadosMoeda.csv";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<DadosMoedaDTO>().ToList();
            }
        }

        private static List<DadosCotacaoDTO> RetornaCSV_DadosCotacao()
        {
            var config = new CsvConfiguration(new System.Globalization.CultureInfo("pt-BR"))
            {
                Delimiter = ";",
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                HeaderValidated = null,
                MissingFieldFound = null
            };

            var path = Directory.GetCurrentDirectory() + @"\Arquivos\DadosCotacao.csv";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<DadosCotacaoDTO>().ToList();
            }
        }
        
        private static void Salvar_Resultado(List<DadosMoedaDTO> dados)
        {
            var config = new CsvConfiguration(new System.Globalization.CultureInfo("pt-BR")){Delimiter = ";", };

            var path = Directory.GetCurrentDirectory() + $"\\Arquivos\\Resultado_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, config))
            {
                var fmtData = new TypeConverterOptions { Formats = new[] { "yyyy-MM-dd" } };
                csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(fmtData);
                csv.Context.TypeConverterOptionsCache.AddOptions<DateTime?>(fmtData);

                csv.WriteRecords(dados);
            }
        }
    }
}
