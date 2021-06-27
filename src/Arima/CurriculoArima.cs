using Arima.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arima
{
    public class CurriculoArima
    {
        public string Nome { get; }
        public string NomeMeio { get; }
        public string SobreNome { get; }
        public string NomeCompleto => $"{Nome} {NomeMeio} {SobreNome}";
        public string NomeSobrenome => $"{Nome} {SobreNome}";
        public string Descricao { get; }
        public DateTime DataNascimento { get; }
        public Contato Contato { get; }
        public string NomePai { get; }
        public string NomeMae { get; }
        public List<string> Filhos { get; }
        public Formacao Formacao { get; }
        public List<Curso> Cursos { get; private set; }
        public List<Profissao> HistoricoProfissional { get; private set; }
        private List<Empresa> Empresas { get; set; }
        public List<Empresa> EmpresasQueTrabalhei => HistoricoProfissional.Select(x => x.Empresa).Distinct().ToList();
        public CurriculoArima()
        {
            Nome = "André";
            NomeMeio = "Hiromi";
            SobreNome = "Arima";
            Descricao = "Analista Desenvolvedor, apaixonado pela Música e pela Família";
            Formacao = new("Analista de Sistemas (Sistemas de Informação)",
                "Bacharel", "Universidade Salgado de Oliveira", "2º Semestre de 2011",
                "Prêmio Destaque Acadêmico Marlene Salgado de Oliveira - 3º Lugar");
            DataNascimento = new(1986, 04, 11);
            NomePai = "Massahiro Arima";
            NomeMae = "Marta T.K. Arima";
            Filhos = new List<string> { "Elis Saori Cirrara Arima" };
            Contato = new Contato("andre.hiromi.arima@gmail.com", "(62)98220-2555", "(62)98220-2555", "https://www.linkedin.com/in/andrehiromiarima/");

            SetEmpresas();
            SetHistoricoProfissional();
            SetCursos();
        }
        private void SetEmpresas()
        {
            Empresas = new List<Empresa>
            {
                new Empresa("Máxima Tech", "Software House", "Focada em sistemas para Atacadista/Distribuidor, Lider do segmento", "https://maximatech.com.br/"),
                new Empresa("SynData Sistemas", "Software House","Automação Comercial e Fiscal","https://www.syndata.com.br/"),
                new Empresa("Centro de Educação Musical Sákura", "Escola de Música","Ensino musical para pessoas de todas as idades", ""),
                new Empresa("Centro de Educação Cultura Musical", "Escola de Música","Ensino musical para pessoas de todas as idades", "http://www.escolademusicacultura.com.br/"),
                new Empresa("Agência de Fomento do Estado de Goiás", "Empresa do Governo de Goiás", "Apoio ao empreendedor através de linhas de crédito","https://www.goiasfomento.com/"),
                new Empresa("Kumagai & Arima SA", "Atacadista do ramo alimentício", "Distruidor de bananas",""),
                new Empresa("Autonomo", "Musico", "Guitarrista, Violonista, Baixista",""),

                //Empresas para Estudo
                new Empresa("Alura", "Educação", "Plataforma de cursos online", "https://www.alura.com.br/"),
                new Empresa("Desenvolvedor.io", "Educação", "Plataforma de cursos online", "https://desenvolvedor.io/"),
                new Empresa("3Way Networks", "Educação", "Plataforma de cursos presenciais/online", "https://www.3way.com.br/"),
                new Empresa("IPOG", "Educação", "Centro de Educação", "https://ipog.edu.br/"),
        };
        }
        private void SetHistoricoProfissional()
        {
            HistoricoProfissional = new List<Profissao>
            {
                new Profissao("Caixa", "Abertura, fechamento, cobrança, recebimento, etc.",
                    "Recebimento de pedidos, Faturamento, Escrita Fiscal, Suporte e Manutenção de Computadores",
                    new DateTime(2005,06,01), new DateTime(2006,06,01),Empresas.FirstOrDefault(x => x.Nome=="Kumagai & Arima SA")),

                new Profissao("Estagiário", "Estágio de Informática",
                    "Suporte e manutenção de computadores, periféricos. Rede interna, Cotações, Cadastros.",
                    new DateTime(2009,03,16), new DateTime(2010,03,15),Empresas.FirstOrDefault(x => x.Nome=="Agência de Fomento do Estado de Goiás")),

                new Profissao("Professor de música","Professor",
                    "Aulas de Guitarra, Violão, Baixo",
                    new DateTime(2012,03,01), new DateTime(2013,03,01), Empresas.FirstOrDefault(x => x.Nome=="Centro de Educação Cultura Musical")),

                new Profissao("Professor de música","Professor",
                    "Aulas de Guitarra, Violão, Baixo",
                    new DateTime(2013,03,01), new DateTime(2016,01,01), Empresas.FirstOrDefault(x => x.Nome=="Centro de Educação Musical Sákura")),

                new Profissao("Músico", "Guitarrista, violonista, baixista", "Gravações, Shows",
                    new DateTime(2004,01,01), new DateTime(2017,01,01), Empresas.FirstOrDefault(x => x.Nome=="Autonomo")),

                new Profissao("Analista de Suporte", "Analista de Suporte do sistema, Analista SPED (ICMS, Contribuições, Sintegra)",
                    "Geração de SPED Fiscais, implantações, migração de banco de dados, treinamentos",
                    new DateTime(2015,07,01), new DateTime(2016,07,01), Empresas.FirstOrDefault(x => x.Nome=="SynData Sistemas"))
            };

            var funcoes = new List<Funcao>
            {
                new Funcao("Analista de Suporte", "Atendimento nivel 1 e posterio nivel 2 aos clientes e todos os produtos da empresa. Forte uso do banco de dados Oracle"),
                new Funcao("Analista de Desenvovimento", "Desenvolvedor .Net / PL-SQL Oracle, responsavel pela manutenção e evolução dos principais produtos da empresa. Responsável Gerencia de Configuração de Software (GCS)"),
                new Funcao("Analista de Desenvolvimento de Sistemas", "Desenvolvedor .Net da Torre que é responsável pela Administração dos recursos usados na AWS e disseminação das melhoras práticas de desenvolvimento")
            };

            HistoricoProfissional.Add(
                new Profissao(funcoes, "Inicio com Suporte ao cliente com promoção a Desenvolvedor .Net",
                    new DateTime(2016, 08, 01), null, Empresas.FirstOrDefault(x => x.Nome == "Máxima Tech"))
                );
        }
        private void SetCursos()
        {
            Cursos = new List<Curso>
            {
                // Alura
                new Curso("Carreira Desenvolvedor ASP.NET MVC5", "Diversos cursos voltado ao desenvolvimento ASP.NET MVC5",
                    new DateTime(2018,06,16), new DateTime(2018,11,03),
                    "https://cursos.alura.com.br/career/certificate/4e513b8a-0587-4415-bbf6-58e55df825ce",
                    Empresas.FirstOrDefault(x => x.Nome == "Alura")),

                new Curso("Carreira Desenvolvedor C#", "Diversos cursos com a base da linguagem C#",
                    new DateTime(2018,06,16), new DateTime(2018,09,12),
                    "https://cursos.alura.com.br/career/certificate/c2a64998-6534-4f1d-ac6f-9933025a7cf9",
                    Empresas.FirstOrDefault(x => x.Nome == "Alura")),

                new Curso("Carreira Oracle SQL e PL/SQL", "Diversos cursos voltado para o Oracle PL/SQL",
                    new DateTime(2018,06,30), new DateTime(2018,07,08),
                    "https://cursos.alura.com.br/career/certificate/e69afca0-a525-4884-821e-84b650491426",
                    Empresas.FirstOrDefault(x => x.Nome == "Alura")),

                new Curso("Todos Alura", "Todos os cursos realizados na plataforma Alura",
                    new DateTime(2018,06,16), new DateTime(2020,06,07),
                    "https://cursos.alura.com.br/user/andre-arima/fullCertificate/deaf8eed7d4e1e9ec004c66f510cb300",
                    Empresas.FirstOrDefault(x => x.Nome == "Alura")),


                //Desenvolvedor IO
                new Curso("Dominando ASP.NET MVC Core", "Curso voltado para ASP.NET MVC Core",
                    new DateTime(2021,05,27), new DateTime(2021,06,14),
                    "https://desenvolvedor.io/certificado/448300e4-fd48-4b87-855e-4ac8b694164c",
                    Empresas.FirstOrDefault(x => x.Nome == "Desenvolvedor.io")),

                new Curso("Fundamentos de Arquitetura de Software", "Fundamentos de arquitetura de software voltado para o .Net",
                    new DateTime(2020,03,21), new DateTime(2020,05,17),
                    "https://desenvolvedor.io/certificado/9ee2a201-84d1-4fc4-b6d5-2f8752bcfcd7",
                    Empresas.FirstOrDefault(x => x.Nome == "Desenvolvedor.io")),

                new Curso("Modelagem de Domínios Ricos", "Linguagem Ubiqua, DDD, CQRS, Event Sourcing...",
                    new DateTime(2020,05,19), new DateTime(2021,05,25),
                    "https://desenvolvedor.io/certificado/4e011040-3801-4db8-92f7-f8740e72d206",
                    Empresas.FirstOrDefault(x => x.Nome == "Desenvolvedor.io")),

                new Curso("Desenvolvimento SPA com Angular", "Curso sobre Angular",
                    new DateTime(2020,07,11), new DateTime(2020,08,07),
                    "https://desenvolvedor.io/certificado/4bdfb713-d4be-45cf-95b7-87f8597fad84",
                    Empresas.FirstOrDefault(x => x.Nome == "Desenvolvedor.io")),

                new Curso("Todos Desenvolvedor.io", "Todos os cursos realizados na plataforma Desenvolvedor.IO",
                    new DateTime(2020,03,13), new DateTime(2021,06,14),
                    "https://desenvolvedor.io/transcript-publico/2d73c784-19e8-4877-9f2b-baf365aceecc",
                    Empresas.FirstOrDefault(x => x.Nome == "Desenvolvedor.io")),


                //3 Way
                new Curso("Java Web e Orientação a Objeto", "Curso de Java Web Básico",
                    new DateTime(2010,01,03), new DateTime(2010,03,03),
                    "",
                    Empresas.FirstOrDefault(x => x.Nome == "3Way Networks")),

                new Curso("DBA Oracle", "Curso sobre o banco de dados Oracle, abrangendo ADM I, II e SQL",
                    new DateTime(2016,10,01), new DateTime(2016,11,15),
                    "",
                    Empresas.FirstOrDefault(x => x.Nome == "3Way Networks")),

                //IPOG
                new Curso("Analista SPED", "Curso sobre o SPED e todas suas vertentes",
                    new DateTime(2016,01,01), new DateTime(2016,02,02),
                    "",
                    Empresas.FirstOrDefault(x => x.Nome == "IPOG")),
            };
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
