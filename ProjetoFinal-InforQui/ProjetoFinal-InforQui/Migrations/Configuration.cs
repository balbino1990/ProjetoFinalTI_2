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
            //#######################################################################################
            //Adiciona os Produtos
            //#######################################################################################
            var produtos = new List<Produtos> {
               new Produtos  {ProdutoID=1, Nome = "Bal�o de Fundo chato",
                           Descricao ="A utiliza��o do Bal�o de Fundo chata � para armazenar, preparar, aquecer ou recolher solu��es. Podem ser de vidro transparente ou �mbar.",
                           Preco="�20,00", Imagem="balao_de_fundo_chato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=2, Nome = "Erlenmeyer",
                           Descricao ="A utiliza��o de Erlenmeyer � para recolher fra��es de materiais destilados ou para conter misturas que ser�o homogeneizadas.",
                           Preco="�50,00", Imagem="Erlenmeyer.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=3, Nome = "B�quer",
                           Descricao ="A utiliza��o do B�quer � resistir o aquecimento, resfriamento e ataques de produtos qu�micos, com escala de pouca precis�o.",
                           Preco="�40,00", Imagem="Calix_Beaker.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=4, Nome = "Funil de Vidro",
                           Descricao ="A utiliza��o de funil de Vidro � para transferir l�quidos e apoiar o papel de filtro",
                           Preco="�20,00", Imagem="funil_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=5, Nome = "Tubos de ensaio",
                           Descricao ="A utiliza��o de tubos de ensaio � fazer rea��es e an�lises de recipientes. Tamb�m utilizados para coleta de amostras em pequena quantidade.",
                           Preco="�20,00", Imagem="tubos_de_ensaio.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=6, Nome = "Condensadores",
                           Descricao ="A condensador consiste por colunas de vidro com tamanho vari�vel entre 10 cm e 1,7 metro, dentro das quais existem tubos em forma reta, espiral ou bolas sequenciais. S�o utilizados em destila��es",
                           Preco="�30,00", Imagem="Condensadores.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=7, Nome = "Bast�o ou baqueta",
                           Descricao ="� um bast�o maci�o de vidro. Serve para agitar e facilitar as dissolu��es ou manter massas l�quidas em constante movimento",
                           Preco="�30,00", Imagem="Baqueta_ou_bast�o.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=8, Nome = "Proveta ou cilindro graduado",
                           Descricao ="A utiliza��o de proveta � serve para medi��o aproximada de volumes maiores de l�quidos",
                           Preco="�30,00", Imagem="proveta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=9, Nome = "Bureta",
                           Descricao ="A Bureta serve para determinar pequenos volumes de reagentes com precis�o. Pode ser de vidro ou de polietileno",
                           Preco="�20,00", Imagem="Bureta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=10, Nome = "Pipetas",
                           Descricao ="Utilizadas para medir e transferir m�nimas quantidades de l�quidos com precis�o. Podem ser graduadas ou volum�tricas",
                           Preco="�10,00", Imagem="pipetas.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=11, Nome = "Bico de Bunsen",
                           Descricao ="Aquecedor a g�s com chama de temperatura vari�vel, de acordo com a regulagem",
                           Preco="�20,00", Imagem="bico_de_bunsen.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=12, Nome = "Cadinho ou c�psula de porcelana",
                           Descricao ="� usada em evapora��o ou secagem e pode ser levada ao fogo sobre tela de amianto",
                           Preco="�30,00", Imagem="Capsupa_de_porcelana.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=13, Nome = "Suporte universal, garra e pin�as de fixa��o",
                           Descricao ="Usados para segurar e sustentar vidrarias, como bal�es e condensadores, entre outros",
                           Preco="�20,00", Imagem="pin�as_e_garras.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=14, Nome = "Trip� de ferro",
                           Descricao ="Usado como apoio para tela de amianto e outros objetos a serem aquecidos",
                           Preco="�20,00", Imagem="tripe_de_ferro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=15, Nome = "Tela de amianto",
                           Descricao ="Suporte para as pe�as a serem aquecidas. A fun��o do amianto � distribuir uniformemente o calor recebido pela chama do bico de Bunsen",
                           Preco="�30,00", Imagem="tela_de_amianto.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=16, Nome = "Estante para tubos de ensaio",
                           Descricao ="� utilizado para apoiar tubos de ensaio",
                           Preco="�20,00", Imagem="estante_para_os_tubos.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=17, Nome = "Funil de Buchner",
                           Descricao ="Usado em filtra��es a v�cuo, pode substituir os cadinhos de Gooch",
                           Preco="�20,00", Imagem="funil_de_bucher.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=18, Nome = "Kitassato",
                           Descricao ="Recipiente de vidro com paredes super-refor�adas e indicado para filtra��es a v�cuo",
                           Preco="�20,00", Imagem="Kitassato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=19, Nome = "Funil de separa��o",
                           Descricao ="Utilizado na separa��o de misturas de l�quidos imisc�veis. Tamb�m pode ser chamado funil de decanta��o ou funil de bromo",
                           Preco="�30,00", Imagem="funil_de_separacao.Jpeg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=20, Nome = "Pisseta",
                           Descricao ="Deve conter solventes, �gua ou solu��es de sab�es e � utilizada para efetuar lavagens de outras vidrarias",
                           Preco="�30,00", Imagem="pisseta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=21, Nome = "Suporte de bureta",
                           Descricao ="Ferramentas para refor�ar a Bureta, a ampola de decanta��o combinado com o anel de suporte ou grampo",
                           Preco="�15,00", Imagem="suporte_de-burreta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=22, Nome = "Jarra de vidro",
                           Descricao ="Como um recipiente que � usado para saturar o eluente no corante de teste",
                           Preco="�30,00", Imagem="jarra_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=23, Nome = "Dessecador",
                           Descricao ="Usado como um lugar para se refrescar equipamentos / materiais e absorver a umidade ap�s a secagem",
                           Preco="�30,00", Imagem="dessecador.jpg", Tipo="Instrumento"},
               new Produtos {ProdutoID=24, Nome="�cido sulf�rico",
                           Descricao ="O �cido sulf�rico, H2SO4, � um �cido mineral forte. � sol�vel na �gua em qualquer concentra��o. Uma caracter�stica peculiar ao �cido sulf�rico � quanto ao seu comportamento relacionado � concentra��o. Quando dilu�do (abaixo de concentra��es molares de 90%), a solu��o assume car�ter de �cido forte e n�o apresenta poder desidratante. Por outro lado, quando � concentrado (acima de 90%), deixa de ter car�ter �cido e acentua-se o seu poder desidratante. Solu��es concentradas deste �cido possuem pH=1,5.",
                           Preco="�60,00", Imagem="Acido_sulfurico.jpg", Tipo="Material"},
               new Produtos {ProdutoID=25, Nome="Bissulfito de s�dio",
                           Descricao="Hidrogenosulfito de s�dio ou bissulfito de s�dio � um composto qu�mico com a f�rmula NaHSO3. Bissulfito de s�dio � um aditivo alimentar com n�mero E E-222. Bissulfito de s�dio em contato com alvejante de cloro (solu��o aquosa de hipoclorito de s�dio) ir� produzir vapores nocivos.",
                           Preco="�50,00", Imagem="Bissulfito_de_Sodio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=26, Nome="B�rax",
                            Descricao="O b�rax (Na2B4O7�10H2O), tamb�m conhecido como Borato de s�dio ou Tetraborato de s�dio � um mineral alcalino derivado da mistura de um sal hidratado de s�dio e �cido b�rico. Facilmente sol�vel em �gua, � frequentemente formado na natureza como evaporito. Por isso � encontrado na forma de pequenos cristais agrupados facilmente fri�vel, com apar�ncia macrosc�pica de um p� esbranqui�ado. Microscopicamente seus cristais s�o transparentes e de pequena dureza.",
                            Preco="�32,00", Imagem="Borax.jpg", Tipo="Material"},
               new Produtos {ProdutoID=27, Nome="Brometo de Pot�ssio",
                            Descricao="Brometo de pot�ssio (KBr) � um composto qu�mico, formado de pot�ssio e bromo, de f�rmula KBr. � um sal s�lido, cristalino de cor branca, higrosc�pico, sol�vel em �gua e em etanol. Devido a sua natureza i�nica, sua solu��o aquosa � um condutor el�trico.",
                            Preco="�30,00", Imagem="Brometo_Potassio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=28, Nome="Brometo de s�dio",
                            Descricao="Brometo de s�dio � um sal com f�rmula NaBr, largamente usado como um anticonvulsivo e um sedativo no s�culo XIX e no in�cio do s�culo XX. Sua a��o se d� pelo �on brometo (brometo de pot�ssio � igualmente efetivo). � um sal s�lido branco cristalino de alto ponto de fus�o que lembra o cloreto de s�dio. � amplamente usado como fonte do �on brometo.",
                            Preco="�40,00", Imagem="Brometo_Sodio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=29, Nome="Butanona",
                            Descricao="Butanona � um composto qu�mico de f�rmula C4H8O ou CH3COC2H3. � um l�quido incolor inflam�vel com um odor doce penetrante. � uma cetona, tamb�m conhecida como metil-etil-cetona (MEK de methyl ethyl ketone).",
                            Preco="�50,00", Imagem="butanona.jpg", Tipo="Material"},
               new Produtos {ProdutoID=30, Nome="Carbonato de am�nio",
                            Descricao="Carbonato de am�nio � o composto qu�mico de f�rmula (NH4)2CO3 conhecido comercialmente como 'sal de am�nio' ou 'sal vol�til'.O carbonato de am�nio � produzido pela hidr�lise da ureia aplicada ao solo. O carbonato de am�nio , sendo um composto inst�vel, na presen�a de �gua, dissocia-se em �ons NH4 e CO3.",
                            Preco="�40,00", Imagem="Carbonato_Amonio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=31, Nome="Carbonato de pot�ssio",
                            Descricao="Carbonato de pot�ssio � um composto qu�mico de f�rmula K2CO3. � um sal branco, sol�vel em �gua (insol�vel em �lcool), na qual forma uma solu��o fortemente alcalina. Pode ser produzido pela rea��o de absor��o de di�xido de carbono pelo hidr�xido de pot�ssio. � deliquescente, frequentemente apresentando-se como um s�lido �mido ou molhado. Misturada com �gua causa uma rea��o exot�rmica que resulta em aumento de temperatura.",
                            Preco="�50,00", Imagem="Carbonato_Potassio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=32, Nome="Enxofre",
                            Descricao="O enxofre (do latim sulphur) � um elemento qu�mico de s�mbolo S, n�mero at�mico 16 e de massa at�mica 32 u. � temperatura ambiente, o enxofre encontra-se no estado s�lido. � um n�o-metal ins�pido e inodoro,(O famoso 'Cheiro de enxofre' vem de seus compostos vol�teis, por exemplo o Sulfeto de hidrog�nio), facilmente reconhecido na forma de cristais amarelos que ocorrem em diversos minerais de sulfito e sulfato, ou mesmo em sua forma pura(especialmente em regi�es vulc�nicas).",
                            Preco="�30,00", Imagem="Enxofre.jpg", Tipo="Material"},
               new Produtos {ProdutoID=33, Nome="Eritorbato de s�dio",
                            Descricao="Eritorbato de s�dio (C6H7NaO6) � usado predominantemente em carnes, aves, e bebidas n�o alco�licas na ind�stria de alimentos.",
                            Preco="�40,00", Imagem="Eritorbato_Sodio.jpeg", Tipo="Material"},
               new Produtos {ProdutoID=34, Nome="Carbonato de Calcio",
                            Descricao="Carbonato de c�lcio � uma subst�ncia qu�mica de f�rmula CaCO3. � o principal componente de rochas como os calc�rios. Tem caracter�sticas alcalinas (ou seja, � um sal com caracter�sticas b�sicas que aumenta o pH de uma solu��o aquosa) e � resultado da rea��o do �xido de c�lcio (cal virgem) com di�xido de carbono.",
                            Preco="�55,50", Imagem="Carbonato_Calcio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=35, Nome="Cloreto de Calcio",
                            Descricao="Cloreto de c�lcio � um composto qu�mico formado por c�lcio e cloro. � extremamente sol�vel em �gua e � deliquescente. � um sal que se apresenta no estado s�lido � temperatura ambiente e comporta-se como um t�pico haleto i�nico.",
                            Preco="�40,30", Imagem="Cloreto_Calcio.jpeg", Tipo="Material"},
               new Produtos {ProdutoID=36, Nome="Cloreto de magn�sio",
                            Descricao="Cloreto de magn�sio � um composto qu�mico de f�rmula MgCl2, usado para diversos fins, designadamente na culin�ria, para prepara��o de tofu a partir do leite de soja, na medicina, com fins terap�uticos, ou mesmo na ind�stria, como anti-congelante ou para produ��o de magn�sio por electr�lise.",
                            Preco="�56,00", Imagem="Cloreto_Magnessio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=37, Nome="Cloreto de am�nio",
                            Descricao="O cloreto de am�nio, cuja f�rmula qu�mica � NH 4 Cl, � um s�lido incolor oubranco, cristaliza no sistema c�bico, possui uma densidade relativa de 1,53 esublima a 340 � C. � muito sol�vel em �gua e ligeiramente sol�vel em etanolmas insol�vel em �ter.",
                            Preco="�40,55", Imagem="Cloreto_Amonio.jpg", Tipo="Material"}
            };

            produtos.ForEach(pp => context.Produtos.AddOrUpdate(p => p.Nome, pp)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                   //pp � variavel interna, => apenas � um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql  

            //################################################################################
            //Adiciona um utilizador
            //################################################################################
            var utilizador = new List<Utilizadores>
            {
                new Utilizadores {UtilizadorID=1, Nome="Santos Pires", Email="santospires@hotmail.com",
                                 Morada ="Santarem", CodPostal="2004-001", NIF="976567764", Contacto="965567323", Imagem="Santos_Pires.png"},
                new Utilizadores {UtilizadorID=2, Nome="Andre Quint�o", Email="andrequintao99@yahoo.com",
                                 Morada ="Entroncamento",  CodPostal="2330-501", NIF="786543987", Contacto="925676332",  Imagem="Andre_Quintao.jpg"},
                new Utilizadores {UtilizadorID=3, Nome="Manuel Pinto Sousa", Email="manuel1982@hotmail.com",
                                 Morada ="Tomar", CodPostal="2300-313", NIF="985345789", Contacto="963387123", Imagem="Manuel_Pinto.png"},
                new Utilizadores {UtilizadorID=4, Nome="Mariano Freitas", Email="freitasmariano90@gmail.com",
                                 Morada ="Torres Novas", CodPostal="2350-222", NIF="723491876", Contacto="966789552", Imagem="Mariano_Freitas.png"},
                new Utilizadores {UtilizadorID=5, Nome="Mario Suares", Email="suares1985@gmail.com",
                                 Morada ="Lisboa", CodPostal="1000-105", NIF="963452679", Contacto="92776929", Imagem="Mario_Suares.jpeg"},
                new Utilizadores {UtilizadorID=6, Nome="Martinho Gusm�o", Email="gusmao1979@hotmail.com",
                                 Morada ="Lisboa", CodPostal="1000-110", NIF="879658976", Contacto="965556743", Imagem="Martinho_Gusmao.jpeg"},
                new Utilizadores {UtilizadorID=7, Nome="Rosito Belo Martins", Email="rositobelo@yahoo.com",
                                 Morada ="Entroncamento", CodPostal="2330-501", NIF="879653289", Contacto="936656992", Imagem="Rosito_Belo.png"},
            };

            utilizador.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                         //uu � variavel interna, => apenas � um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql


            //################################################################################
            //Adiciona uma compra
            //################################################################################
            var compra = new List<Compras>
            {
                new Compras {CompraID=1, Data=new DateTime(2016, 7, 9), UtilizadorFK=1},
                new Compras {CompraID=2, Data=new DateTime(2015, 9, 9), UtilizadorFK=3},
                new Compras {CompraID=3, Data=new DateTime(2017, 1, 7), UtilizadorFK=7},
                new Compras {CompraID=4, Data=new DateTime(2012, 2, 27), UtilizadorFK=5},
                new Compras {CompraID=5, Data=new DateTime(2011, 9, 17), UtilizadorFK=4},
                new Compras {CompraID=6, Data=new DateTime(2013, 10, 20), UtilizadorFK=7},
                new Compras {CompraID=7, Data=new DateTime(2016, 9, 16), UtilizadorFK=2},
                new Compras {CompraID=8, Data=new DateTime(2014, 11, 19), UtilizadorFK=1},
                new Compras {CompraID=9, Data=new DateTime(2012, 9, 23), UtilizadorFK=4},
                new Compras {CompraID=10, Data=new DateTime(2015, 5, 15), UtilizadorFK=3},
                new Compras {CompraID=11, Data=new DateTime(2014, 9, 8), UtilizadorFK=7},
                new Compras {CompraID=12, Data=new DateTime(2013, 9, 17), UtilizadorFK=6},
                new Compras {CompraID=13, Data=new DateTime(2010, 2, 18), UtilizadorFK=5},
                new Compras {CompraID=14, Data=new DateTime(2011, 8, 29), UtilizadorFK=5},
                new Compras {CompraID=15, Data=new DateTime(2016, 9, 12), UtilizadorFK=7},
                new Compras {CompraID=16, Data=new DateTime(2015, 12, 11), UtilizadorFK=3},
                new Compras {CompraID=17, Data=new DateTime(2012, 9, 10), UtilizadorFK=2}
            };

            compra.ForEach(cc => context.Compras.AddOrUpdate(c => c.Data, cc));//metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                        //cc � variavel interna, => apenas � um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql

            //################################################################################
            //Adiciona uma Compra_Produto
            //################################################################################
            var compraProduto = new List<Compras_Produtos>
            {
                new Compras_Produtos {Compras_ProdutoID=1, Quantidade=2, Preco="�120,00", CompraFK=1, ProdutoFK=2},
                new Compras_Produtos {Compras_ProdutoID=2, Quantidade=4, Preco="�200,00", CompraFK=3, ProdutoFK=5},
                new Compras_Produtos {Compras_ProdutoID=3, Quantidade=1, Preco="�50,00", CompraFK=2, ProdutoFK=6},
                new Compras_Produtos {Compras_ProdutoID=4, Quantidade=2, Preco="�160,00", CompraFK=5, ProdutoFK=9},
                new Compras_Produtos {Compras_ProdutoID=5, Quantidade=4, Preco="�300,00", CompraFK=7, ProdutoFK=10},
                new Compras_Produtos {Compras_ProdutoID=6, Quantidade=3, Preco="�200,00", CompraFK=8, ProdutoFK=11},
                new Compras_Produtos {Compras_ProdutoID=7, Quantidade=5, Preco="�400,00", CompraFK=9, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=8, Quantidade=4, Preco="�300,00", CompraFK=10, ProdutoFK=1},
                new Compras_Produtos {Compras_ProdutoID=9, Quantidade=2, Preco="�250,00", CompraFK=2, ProdutoFK=23},
                new Compras_Produtos {Compras_ProdutoID=10, Quantidade=5, Preco="�600,00", CompraFK=1, ProdutoFK=17},
                new Compras_Produtos {Compras_ProdutoID=11, Quantidade=4, Preco="�300,00", CompraFK=6, ProdutoFK=14},
                new Compras_Produtos {Compras_ProdutoID=12, Quantidade=3, Preco="�400,00", CompraFK=8, ProdutoFK=24},
                new Compras_Produtos {Compras_ProdutoID=13, Quantidade=4, Preco="�400,00", CompraFK=9, ProdutoFK=25},
                new Compras_Produtos {Compras_ProdutoID=14, Quantidade=4, Preco="�300,00", CompraFK=10, ProdutoFK=27},
                new Compras_Produtos {Compras_ProdutoID=15, Quantidade=5, Preco="�450,00", CompraFK=11, ProdutoFK=28},
                new Compras_Produtos {Compras_ProdutoID=16, Quantidade=4, Preco="�350,00", CompraFK=8, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=17, Quantidade=4, Preco="�350,00", CompraFK=9, ProdutoFK=18},
                new Compras_Produtos {Compras_ProdutoID=18, Quantidade=3, Preco="�150,00", CompraFK=10, ProdutoFK=19},
                new Compras_Produtos {Compras_ProdutoID=19, Quantidade=6, Preco="�200,00", CompraFK=12, ProdutoFK=20},
                new Compras_Produtos {Compras_ProdutoID=20, Quantidade=3, Preco="�300,00", CompraFK=2, ProdutoFK=21},
                new Compras_Produtos {Compras_ProdutoID=21, Quantidade=4, Preco="�500,00", CompraFK=6, ProdutoFK=22},
                new Compras_Produtos {Compras_ProdutoID=22, Quantidade=4, Preco="�500,00", CompraFK=8, ProdutoFK=12},
                new Compras_Produtos {Compras_ProdutoID=23, Quantidade=5, Preco="�550,00", CompraFK=9, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=24, Quantidade=8, Preco="�800,00", CompraFK=12, ProdutoFK=19},
                new Compras_Produtos {Compras_ProdutoID=25, Quantidade=6, Preco="�550,00", CompraFK=7, ProdutoFK=29},
                new Compras_Produtos {Compras_ProdutoID=26, Quantidade=4, Preco="�400,00", CompraFK=9, ProdutoFK=30}
            };

            compraProduto.ForEach(cp => context.Compras_Produtos.Add(cp)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                           //cp � variavel interna, => apenas � um simbolo de C#, significa 
            context.SaveChanges();                                         //igual o commit do mySql
        }
    }
}
