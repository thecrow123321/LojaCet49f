using System;
using System.ComponentModel.DataAnnotations;

namespace lojacet49f.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        // mostra de uma forma e o apply format permite que o utilizador escolha como deve ser submetido
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]



        public decimal Preco { get; set; }


        [Display(Name = "Imagem")] //mostra a imagem
        public string UrlDaImagem { get; set; }

        //nao se poe imagem na base de dados porque é muito espaço e custa dinheiro


        //data da ultima compra
        public DateTime UltimaCompra { get; set; }//get= leitura set= escrita

        [Display(Name = "Última venda")]
        public DateTime UltimaVenda { get; set; }

        [Display(Name = "Disponivel")]
        public bool Disponivel { get; set; }


        //Aqui troqueio o C pelo N porque o stock e um numero com casas decimais C é moeda 
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        // é um duplo porque para eu poder querer 1,5L de agua ou azeite.



    }
}
