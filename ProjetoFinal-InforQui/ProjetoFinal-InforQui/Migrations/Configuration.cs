namespace ProjetoFinal_InforQui.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoFinal_InforQui.Models.InforQuiDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoFinal_InforQui.Models.InforQuiDB context)
        {
            var produtos = new List<Produtos> {
               new Produtos  {ProdutosID=1, Nome = "Balão de Fundo chato",
                           Descricao ="A utilização do Balão de Fundo chata é para armazenar, preparar, aquecer ou recolher soluções. Podem ser de vidro transparente ou âmbar.",
                           Preco="$20,00", Marca="", Imagem="balao_de_fundo_chato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=2, Nome = "2.	Erlenmeyer",
                           Descricao ="A utilização de Erlenmeyer é para recolher frações de materiais destilados ou para conter misturas que serão homogeneizadas.",
                           Preco="$50,00", Marca="", Imagem="Erlenmeyer.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=3, Nome = "Béquer",
                           Descricao ="A utilização do Béquer é resistir o aquecimento, resfriamento e ataques de produtos químicos, com escala de pouca precisão.",
                           Preco="$40,00", Marca="", Imagem="Calix_Beaker.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=4, Nome = "Funil de Vidro",
                           Descricao ="A utilização de funil de Vidro é para transferir líquidos e apoiar o papel de filtro",
                           Preco="$20,00", Marca="", Imagem="funil_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=5, Nome = "Tubos de ensaio",
                           Descricao ="A utilização de tubos de ensaio é fazer reações e análises de recipientes. Também utilizados para coleta de amostras em pequena quantidade.",
                           Preco="$20,00", Marca="", Imagem="tubos_de_ensaio.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=6, Nome = "Condensadores",
                           Descricao ="A condensador consiste por colunas de vidro com tamanho variável entre 10 cm e 1,7 metro, dentro das quais existem tubos em forma reta, espiral ou bolas sequenciais. São utilizados em destilações",
                           Preco="$30,00", Marca="", Imagem="Condensadores.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=7, Nome = "Bastão ou baqueta",
                           Descricao ="É um bastão maciço de vidro. Serve para agitar e facilitar as dissoluções ou manter massas líquidas em constante movimento",
                           Preco="$30,00", Marca="", Imagem="Baqueta_ou_bastão.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=8, Nome = "Proveta ou cilindro graduado",
                           Descricao ="A utilização de proveta é serve para medição aproximada de volumes maiores de líquidos",
                           Preco="$30,00", Marca="", Imagem="proveta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=9, Nome = "Bureta",
                           Descricao ="A Bureta serve para determinar pequenos volumes de reagentes com precisão. Pode ser de vidro ou de polietileno",
                           Preco="$20,00", Marca="", Imagem="Bureta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=10, Nome = "Pipetas",
                           Descricao ="Utilizadas para medir e transferir mínimas quantidades de líquidos com precisão. Podem ser graduadas ou volumétricas",
                           Preco="$10,00", Marca="", Imagem="pipetas.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=11, Nome = "Bico de Bunsen",
                           Descricao ="Aquecedor a gás com chama de temperatura variável, de acordo com a regulagem",
                           Preco="$20,00", Marca="", Imagem="bico_de_bunsen.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=12, Nome = "Cadinho ou cápsula de porcelana",
                           Descricao ="É usada em evaporação ou secagem e pode ser levada ao fogo sobre tela de amianto",
                           Preco="$30,00", Marca="", Imagem="Capsupa_de_porcelana.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=13, Nome = "Suporte universal, garra e pinças de fixação",
                           Descricao ="Usados para segurar e sustentar vidrarias, como balões e condensadores, entre outros",
                           Preco="$20,00", Marca="", Imagem="pinças_e_garras.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=14, Nome = "Tripé de ferro",
                           Descricao ="Usado como apoio para tela de amianto e outros objetos a serem aquecidos",
                           Preco="$20,00", Marca="", Imagem="tripe_de_ferro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=15, Nome = "Tela de amianto",
                           Descricao ="Suporte para as peças a serem aquecidas. A função do amianto é distribuir uniformemente o calor recebido pela chama do bico de Bunsen",
                           Preco="$30,00", Marca="", Imagem="tela_de_amianto.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=16, Nome = "Estante para tubos de ensaio",
                           Descricao ="É utilizado para apoiar tubos de ensaio",
                           Preco="$20,00", Marca="", Imagem="estante_para_os_tubos.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=17, Nome = "Funil de Buchner",
                           Descricao ="Usado em filtrações a vácuo, pode substituir os cadinhos de Gooch",
                           Preco="$20,00", Marca="", Imagem="funil_de_bucher.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=18, Nome = "Kitassato",
                           Descricao ="Recipiente de vidro com paredes super-reforçadas e indicado para filtrações a vácuo",
                           Preco="$20,00", Marca="", Imagem="Kitassato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=19, Nome = "Funil de separação",
                           Descricao ="Utilizado na separação de misturas de líquidos imiscíveis. Também pode ser chamado funil de decantação ou funil de bromo",
                           Preco="$30,00", Marca="", Imagem="funil_de_separacao.Jpeg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=20, Nome = "Pisseta",
                           Descricao ="Deve conter solventes, água ou soluções de sabões e é utilizada para efetuar lavagens de outras vidrarias",
                           Preco="$30,00", Marca="", Imagem="pisseta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=21, Nome = "Suporte de bureta",
                           Descricao ="Ferramentas para reforçar a Bureta, a ampola de decantação combinado com o anel de suporte ou grampo",
                           Preco="$15,00", Marca="", Imagem="suporte_de-burreta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=22, Nome = "Jarra de vidro",
                           Descricao ="Como um recipiente que é usado para saturar o eluente no corante de teste",
                           Preco="$30,00", Marca="", Imagem="jarra_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=23, Nome = "Dessecador",
                           Descricao ="Usado como um lugar para se refrescar equipamentos / materiais e absorver a umidade após a secagem",
                           Preco="$30,00", Marca="", Imagem="dessecador.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=24, Nome = "Eksikator",
                           Descricao ="",
                           Preco="$30,00", Marca="", Imagem="eksikator.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=25, Nome = "Destilação",
                           Descricao ="",
                           Preco="$30,00", Marca="", Imagem="Destilacao.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=26, Nome = "Papel Indicador",
                           Descricao ="",
                           Preco="$30,00", Marca="", Imagem="papel_indicador.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=27, Nome = "Mortero",
                           Descricao ="",
                           Preco="$20,00", Marca="", Imagem="mortero.jpg", Tipo="Instrumento"}

            };

            produtos.ForEach(pp => context.Produtos.AddOrUpdate(p => p.Nome, pp)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                   //dd é variavel interna, => apenas é um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql
        }
    }
}
