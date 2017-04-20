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
               new Produtos  {ProdutosID=1, Nome = "Bal�o de Fundo chato",
                           Descricao ="A utiliza��o do Bal�o de Fundo chata � para armazenar, preparar, aquecer ou recolher solu��es. Podem ser de vidro transparente ou �mbar.",
                           Preco="$20,00", Marca="", Imagem="balao_de_fundo_chato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=2, Nome = "2.	Erlenmeyer",
                           Descricao ="A utiliza��o de Erlenmeyer � para recolher fra��es de materiais destilados ou para conter misturas que ser�o homogeneizadas.",
                           Preco="$50,00", Marca="", Imagem="Erlenmeyer.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=3, Nome = "B�quer",
                           Descricao ="A utiliza��o do B�quer � resistir o aquecimento, resfriamento e ataques de produtos qu�micos, com escala de pouca precis�o.",
                           Preco="$40,00", Marca="", Imagem="Calix_Beaker.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=4, Nome = "Funil de Vidro",
                           Descricao ="A utiliza��o de funil de Vidro � para transferir l�quidos e apoiar o papel de filtro",
                           Preco="$20,00", Marca="", Imagem="funil_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=5, Nome = "Tubos de ensaio",
                           Descricao ="A utiliza��o de tubos de ensaio � fazer rea��es e an�lises de recipientes. Tamb�m utilizados para coleta de amostras em pequena quantidade.",
                           Preco="$20,00", Marca="", Imagem="tubos_de_ensaio.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=6, Nome = "Condensadores",
                           Descricao ="A condensador consiste por colunas de vidro com tamanho vari�vel entre 10 cm e 1,7 metro, dentro das quais existem tubos em forma reta, espiral ou bolas sequenciais. S�o utilizados em destila��es",
                           Preco="$30,00", Marca="", Imagem="Condensadores.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=7, Nome = "Bast�o ou baqueta",
                           Descricao ="� um bast�o maci�o de vidro. Serve para agitar e facilitar as dissolu��es ou manter massas l�quidas em constante movimento",
                           Preco="$30,00", Marca="", Imagem="Baqueta_ou_bast�o.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=8, Nome = "Proveta ou cilindro graduado",
                           Descricao ="A utiliza��o de proveta � serve para medi��o aproximada de volumes maiores de l�quidos",
                           Preco="$30,00", Marca="", Imagem="proveta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=9, Nome = "Bureta",
                           Descricao ="A Bureta serve para determinar pequenos volumes de reagentes com precis�o. Pode ser de vidro ou de polietileno",
                           Preco="$20,00", Marca="", Imagem="Bureta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=10, Nome = "Pipetas",
                           Descricao ="Utilizadas para medir e transferir m�nimas quantidades de l�quidos com precis�o. Podem ser graduadas ou volum�tricas",
                           Preco="$10,00", Marca="", Imagem="pipetas.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=11, Nome = "Bico de Bunsen",
                           Descricao ="Aquecedor a g�s com chama de temperatura vari�vel, de acordo com a regulagem",
                           Preco="$20,00", Marca="", Imagem="bico_de_bunsen.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=12, Nome = "Cadinho ou c�psula de porcelana",
                           Descricao ="� usada em evapora��o ou secagem e pode ser levada ao fogo sobre tela de amianto",
                           Preco="$30,00", Marca="", Imagem="Capsupa_de_porcelana.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=13, Nome = "Suporte universal, garra e pin�as de fixa��o",
                           Descricao ="Usados para segurar e sustentar vidrarias, como bal�es e condensadores, entre outros",
                           Preco="$20,00", Marca="", Imagem="pin�as_e_garras.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=14, Nome = "Trip� de ferro",
                           Descricao ="Usado como apoio para tela de amianto e outros objetos a serem aquecidos",
                           Preco="$20,00", Marca="", Imagem="tripe_de_ferro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=15, Nome = "Tela de amianto",
                           Descricao ="Suporte para as pe�as a serem aquecidas. A fun��o do amianto � distribuir uniformemente o calor recebido pela chama do bico de Bunsen",
                           Preco="$30,00", Marca="", Imagem="tela_de_amianto.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=16, Nome = "Estante para tubos de ensaio",
                           Descricao ="� utilizado para apoiar tubos de ensaio",
                           Preco="$20,00", Marca="", Imagem="estante_para_os_tubos.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=17, Nome = "Funil de Buchner",
                           Descricao ="Usado em filtra��es a v�cuo, pode substituir os cadinhos de Gooch",
                           Preco="$20,00", Marca="", Imagem="funil_de_bucher.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=18, Nome = "Kitassato",
                           Descricao ="Recipiente de vidro com paredes super-refor�adas e indicado para filtra��es a v�cuo",
                           Preco="$20,00", Marca="", Imagem="Kitassato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=19, Nome = "Funil de separa��o",
                           Descricao ="Utilizado na separa��o de misturas de l�quidos imisc�veis. Tamb�m pode ser chamado funil de decanta��o ou funil de bromo",
                           Preco="$30,00", Marca="", Imagem="funil_de_separacao.Jpeg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=20, Nome = "Pisseta",
                           Descricao ="Deve conter solventes, �gua ou solu��es de sab�es e � utilizada para efetuar lavagens de outras vidrarias",
                           Preco="$30,00", Marca="", Imagem="pisseta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=21, Nome = "Suporte de bureta",
                           Descricao ="Ferramentas para refor�ar a Bureta, a ampola de decanta��o combinado com o anel de suporte ou grampo",
                           Preco="$15,00", Marca="", Imagem="suporte_de-burreta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=22, Nome = "Jarra de vidro",
                           Descricao ="Como um recipiente que � usado para saturar o eluente no corante de teste",
                           Preco="$30,00", Marca="", Imagem="jarra_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=23, Nome = "Dessecador",
                           Descricao ="Usado como um lugar para se refrescar equipamentos / materiais e absorver a umidade ap�s a secagem",
                           Preco="$30,00", Marca="", Imagem="dessecador.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=24, Nome = "Eksikator",
                           Descricao ="",
                           Preco="$30,00", Marca="", Imagem="eksikator.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutosID=25, Nome = "Destila��o",
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
                                                                                   //dd � variavel interna, => apenas � um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql
        }
    }
}
