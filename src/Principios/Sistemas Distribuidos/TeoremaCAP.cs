using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Principios.Sistemas_Distribuidos
{
    public class TeoremaCAP
    {
        public string Descricao = "Segundo o teorema, temos que escolher duas opções para garantir, sendo a que sobrar, prejudicada";

        private readonly Consistency _consistencia;
        private readonly Availability _disponibilidade;
        private readonly PartitionTolerance _toleranciaFalhas;
        private readonly PilarOptions _options;
        public TeoremaCAP(PilarOptions options)
        {
            _options = options;
            switch (options)
            {
                case PilarOptions.AP:
                    _disponibilidade = new Availability();
                    _toleranciaFalhas = new PartitionTolerance();
                    _consistencia = null;
                    break;
                case PilarOptions.AC:
                    _disponibilidade = new Availability();
                    _consistencia = new Consistency();
                    _toleranciaFalhas = null;
                    break;
                case PilarOptions.CP:
                    _consistencia = new Consistency();
                    _toleranciaFalhas = new PartitionTolerance();
                    _disponibilidade = null;
                    break;
                default:
                    break;
            }
        }
        public List<string> Bancos
        {
            get
            {
                return _options switch
                {
                    PilarOptions.AC => new List<string>
                        {
                            "RDBMS (MySQL, Oracle, Postgres)",
                            "Aster Data",
                            "Greenplum",
                            "Vertica",
                            "ToroDB",
                            "neo4j"
                        },
                    PilarOptions.AP => new List<string>
                        {
                            "Dynamo",
                            "Voldemort",
                            "Tokyo Cabinet",
                            "KAI",
                            "Cassandra",
                            "SimpleDB",
                            "CouchDB",
                            "Riak"
                        },
                    PilarOptions.CP => new List<string>
                        {
                            "BigTable",
                            "Hypertable",
                            "HBase",
                            "MongoDB",
                            "Terrastore",
                            "Scalaris",
                            "Berkeley DB",
                            "MemcacheDB",
                            "Redis"
                        },
                    _ => throw new Exception("nenhuma opção definida."),
                };
            }
        }
    }
    public enum PilarOptions
    {
        [Display(Name = "Availability and Partition Tolerance - Disponibilidade e Tolerância a Falhas")]
        AP,
        [Display(Name = "Availability and Consistency - Disponibilidade e Consistência")]
        AC,
        [Display(Name = "Consistency and Partition Tolerance - Consistência e Tolerância a Falhas")]
        CP
    }
    public abstract class Pilar
    {
        protected string Nome;
        protected string Descricao;
    }
    public class Consistency : Pilar
    {
        public Consistency()
        {
            Nome = "Consistência";
            Descricao = "Cada leitura recebe a escrita mais recente ou um erro.";
        }
    }
    public class Availability : Pilar
    {
        public Availability()
        {
            Nome = "Disponibilidade";
            Descricao = "Cada pedido recebe uma resposta (sem erro) - sem garantia de que contém a escrita mais recente.";
        }
    }
    public class PartitionTolerance : Pilar
    {
        public PartitionTolerance()
        {
            Nome = "Tolerância a Falhas - Tolerance to network Partitions";
            Descricao = "O sistema continua a funcionar apesar de número arbitrário de mensagens serem descartadas (ou atrasadas) pela rede entre nós.";
        }
    }
}
