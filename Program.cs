﻿using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

Pessoa p2 = new Pessoa(nome: "Marcelo", sobrenome: "Cordeiro");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

