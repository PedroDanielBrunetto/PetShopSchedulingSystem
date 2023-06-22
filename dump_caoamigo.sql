CREATE DATABASE DB_DUMP_CAOAMIGO character set='UTF8' collate='UTF8_general_ci';

USE DB_DUMP_CAOAMIGO;

CREATE TABLE TB_FUNCIONARIO (
	id_funcionario INT NOT NULL PRIMARY KEY auto_increment,
    nm_funcionario varchar(80) not null,
    nm_user varchar(80) not null,
    nm_email varchar(80) not null unique,
    pw_funcionario varchar(80) not null
)engine InnoDB;

CREATE TABLE TB_TUTOR (
	id_tutor INT NOT NULL PRIMARY KEY auto_increment,
    nm_tutor varchar(80) not null,
    nm_email varchar(80) not null,
    tl_tutor char(12),
    cd_cpf char (11) not null unique,
)engine InnoDB;

CREATE TABLE TB_PET (
	id_pet INT NOT NULL PRIMARY KEY auto_increment,
    nm_pet varchar(80) not null,
    id_tutor int not null,
    tp_animal varchar(10) not null,
    tp_raça varchar(80) not null,
    constraint fk_id_tutor FOREIGN KEY (id_tutor) REFERENCES TB_TUTOR (id_tutor)
)engine InnoDB;

CREATE TABLE TB_AGENDAMENTO (
	id_servico INT NOT NULL PRIMARY KEY auto_increment,
    dt_servico datetime not null unique,
    tp_servico varchar(30) not null,
    vl_servico char(5) not null,
    id_tutor int not null,
    id_pet int not null,
    constraint fk_id_tutorAgenda FOREIGN KEY (id_tutor) REFERENCES TB_TUTOR (id_tutor),
    constraint fk_id_pet FOREIGN KEY (id_pet) REFERENCES TB_PET (id_pet)
)engine InnoDB;