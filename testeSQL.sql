--1.
SELECT COUNT(*) QuantidadeProcessos, S.dsStatus StatusDescricao
FROM tb_Processo P
INNER JOIN tb_Status S ON(S.idStatus = P.idStatus)
GROUP BY S.dsStatus

--2.
SELECT MAX(A.dtAndamento) MaiorDataAndamento, nroProcesso
FROM tb_Andamento A
INNER JOIN tb_Processo P ON(P.idProcesso = A.idProcesso)
INNER JOIN tb_Status S ON(S.idStatus = P.idStatus)
WHERE YEAR(dtEncerramento) = 2013
GROUP BY P.nroProcesso

--3
SELECT A.DtEncerramento, COUNT(*) Contagem
FROM tb_Processo A
GROUP BY A.DtEncerramento
HAVING COUNT(*) > 5

--4
DECLARE @TotalLen INT = 12
SELECT RIGHT(REPLICATE('0', @TotalLen) + 
	CAST(nroProcesso as varchar(12)), @TotalLen) nroProcesso
FROM tb_Processo