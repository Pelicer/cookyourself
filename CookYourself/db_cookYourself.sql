----------------- Database ------------------
drop database db_cookYourself;          /*/*/
create database db_cookYourself;        /*/*/
use db_cookYourself;                    /*/*/
---------------------------------------------

------------------ User ---------------------
create table tbl_user(                  /*/*/
user_id int auto_increment not null,    /*/*/
user_name varchar (50),                 /*/*/
user_password varchar (50),             /*/*/
primary key(user_id)                    /*/*/
);                                      /*/*/
---------------------------------------------

------------------ Receita ---------------------
create table tbl_receita(
receita_id int auto_increment not null,
receita_ingrediente1 varchar(50),
receita_ingrediente2 varchar(50),
receita_ingrediente3 varchar(50),
receita_ingrediente4 varchar(50),
receita_ingrediente5 varchar(50),
receita_ingrediente6 varchar(50),
receita_ingrediente7 varchar(50),
receita_ingrediente8 varchar(50),
receita_ingrediente9 varchar(50),
receita_ingrediente10 varchar(50),
receita_titulo varchar(30),
receita_preparo varchar(2000),
receita_tipo varchar (15),
receita_rendimento varchar (30),
receita_tempoPreparo varchar (30),
receita_custoTotal varchar (30),
primary key(receita_id)
);
-- ----------------------------------------------

create table tbl_mensagens(
mensagem_id int auto_increment not null,
mensagem_autor varchar(30) not null,
mensagem_email varchar(30) not null,
mensagem_conteudo varchar(1000) not null,
primary key(mensagem_id)
);

insert into tbl_user(user_name, user_password) values ('ana', 'ana');

select * from tbl_mensagens;

insert into tbl_receita(receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6, receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento, receita_tempoPreparo, receita_custoTotal) values('1 kg de peito de frango', '1 pacote de macarrão para lasanha', '3 gemas', '300 g de presunto fatiado', '300 g de mussarela fatiada', '2 xícaras de chá de leite', '1 caixinha de creme de leite', '4 colheres de farinha de trigo', 'Queijo ralado (opcional)', '', 'Lasanha de Frango', 'Cozinhe o peito de frango com os temperos de costume (cheiro verde, alho, cebola, extrato de tomate, pimenta do reino)Coloque bastante água pra que fique muito caldoQuando o frango estiver cozido, retire-o da panela e coloque em outro recipiente para que esfriePegue o caldo que ficou do frango, coloque no liquidificador com: as gemas, o leite, a farinha de trigo e 1 colher (sopa) de queijo ralado Bata tudo muito bem Depois de bem batido, coloque em uma panela e leve ao fogo baixo até engrossar e levantar fervura Quando ferver, desligue o fogo e coloque o creme de leite, misture tudo muito bem e reserve Corte o presunto em cubinhos (coloque uma fatia em cima da outra e faça cortes horizontais e verticais) Despeje em uma tigela, corte a mussarela do mesmo modo que o presunto e coloque junto com o presunto Desfie o peito de frango e junte ao presunto e a mussarela, misture-os bem Agora é só montar a lasanha Em uma travessa de vidro grande coloque uma camada do molho, uma camada de macarrão e o recheio (de frango, presunto e mussarela) outra camada de macarrão, molho e recheio Alterne camadas até preencher toda a travessa ou acabar a massa A penúltima camada deve ser de macarrão e a última de molho Se optou pelo queijo ralado, espalhe-o por cima da lasanha depois de pronta Leve ao forno até que a camada de molho fique um pouco mais escura, até que ferver (a camada de molho começar a formar bolhinhas de ar, como se estivesse mesmo fervendo), ou que o queijo ralado derreta Pronto é só saborear Você pode optar por coloca junto com o recheio: milho verde, ervilha, azeitonas picadas Mas sugiro que façam primeiro como diz a receita, porque o molho por si só já basta', 'Salgado', '8 porções', '1h', 'R$ 50,00');
insert into tbl_receita(receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6, receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento, receita_tempoPreparo, receita_custoTotal) values('40 ml de tequila', '20 ml de Cointreau', '2 colheres de suco de limão', 'Cubos de gelo', 'Sal', '', '', '', '', '', 'Margarita mexicana', 'Molhe a boca do copo para coquetel com suco de limão. Encoste no sal para formar uma borda. Junte em uma coqueteleira a tequila, o Cointreau, o suco de limão, e uma xícara de cubos de gelo. Misture bem e coe sobre o copo.', 'Bebida', '1 Drink', '5 minutos', 'R$ 20,00');
insert into tbl_receita(receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6, receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento, receita_tempoPreparo, receita_custoTotal) values('02 latas de leite condensado', '02 latas de leite', '06 ovos', '', '', '', '', '', '', '', 'Pudim de Leite Condensado', 'Bater todos ingredientes no liquidificador. Caramelize a forma de buraco Coloque o que foi batido no liquidificador na forma e tampe com papel alumínio e leve ao forno em banho maria aproximadamente por 1 hora. OBS:* De preferência a todos os ingredientes ser em temperatura ambiente.* Depois do pudim assado coloque para esfriar e leve a geladeira para depois desenformar.', 'Doce', '10 porções', '1h30 mnutos', 'R$ 20,00');
insert into tbl_receita(receita_ingrediente1, receita_ingrediente2, receita_ingrediente3, receita_ingrediente4, receita_ingrediente5, receita_ingrediente6, receita_ingrediente7, receita_ingrediente8, receita_ingrediente9, receita_ingrediente10, receita_titulo, receita_preparo, receita_tipo, receita_rendimento, receita_tempoPreparo, receita_custoTotal) values('1 peito de frango cozido e desfiado', '3 colheres de maionese', '2 cenouras descascadas e raladas', '1 lata de milho verde', '200 g de presunto', '200 g de queijo', '1 pacote de pão de forma', 'Alface e tomate', '', '', 'Lanche Natural', 'Misture os quatro primeiro ingredientes, depois passe no pão. Coloque alface, tomate, queijo e o presunto. Sirva em seguida', 'Lanche', '1 unidade', '5 minutos', 'R$ 20,00');