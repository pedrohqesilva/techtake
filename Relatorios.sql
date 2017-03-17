-- TESTES PARA RANKING DO INSTRUTOR

    SELECT * FROM ranking;
	
	-- Teste funcional, onde agrupa as notas, faz a media e informa ordenado por nota maior.
    SELECT p.nome AS 'Nome do Instrutor', AVG(pontuacao) AS 'Média de Pontos do Instrutor'
        FROM ranking r
            JOIN pessoa p
                ON r.instrutor_id = p.id
                    GROUP BY(Instrutor_id)
						ORDER BY AVG(pontuacao) DESC;
						
						
-- TESTES PARA RANKING DO INSTRUTOR						
	
	-- Teste para calcular a soma total do valor das aulas
		SELECT SUM(valor) AS 'Soma total' FROM Aula;
	
	-- Teste para calcular a soma total do valor das aulas de cada professor
		SELECT p.nome AS 'Nome do Instrutor', SUM(valor) AS 'Soma total' 
			FROM Aula a JOIN Pessoa p
				ON a.Instrutor_id = p.id
					WHERE data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE() 
						GROUP BY nome;
	
	-- Teste onde calcula a soma do valor das aulas (separadas entre L e P) nos ultimos 30 dias.
		SELECT tipo AS 'Tipo de Aula', SUM(valor) AS 'Soma do Mês' FROM Aula 
			WHERE data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE() 
				GROUP BY(tipo);		
		
-- TESTES PARA ALUNOS

	-- Selecionar todos os alunos
		SELECT id AS 'Cod', nome AS 'Nome', sexo AS 'Sexo', nascimento AS 'Data de Nascimento', cpf AS 'CPF', rg AS 'RG',
		    telefone AS 'Telefone', cep AS 'CEP', logradouro AS 'Logradouro', numero AS 'Num.', complemento AS 'Compl.',
		        bairro AS 'Bairro', cidade AS 'Cidade', uf AS 'UF' FROM Pessoa WHERE tipo = "Aluno";		
		
		
		
		
		
		
		