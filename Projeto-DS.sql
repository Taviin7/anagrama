drop database if exists Anagrama;
create database Anagrama;
use Anagrama;

create table Palavras(
ID int not null primary key auto_increment,
Palavra varchar (255),
Dificuldade varchar (255)
);

insert into Palavras (Palavra, Dificuldade ) VALUES
("acne", "Fácil"),("canal", "Fácil"),("canela", "Fácil"),("cela", "Fácil"),("acena", "Fácil");

insert into Palavras (Palavra, Dificuldade) VALUES
("amor", "Médio"),("roma", "Médio"),("romã", "Médio"),
("namora", "Médio"),("adora", "Médio"),("morno", "Médio"),("morna", "Médio"),("ramo", "Médio");

insert into Palavras (Palavra, Dificuldade) VALUES
("zoo", "Difícil"),("ódio", "Difícil"),("chá", "Difícil"),("oca", "Difícil"),("oco", "Difícil"),
("cio", "Difícil"),("noa", "Difícil"),("dica", "Difícil"),("doca", "Difícil"),("dona", "Difícil"),
("dono", "Difícil"),("zinco", "Difícil"),("canho", "Difícil"),("cozinha", "Difícil");

select * from Palavras;
