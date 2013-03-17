-- Trevor Marsh
-- 3/16/13
-- Database creation setup

USE master

IF EXISTS (SELECT * FROM sys.databases d WHERE d.name = 'CLEANCODE')
DROP DATABASE CLEANCODE

GO

CREATE DATABASE CLEANCODE
GO

USE CLEANCODE

-- The basic info for a user account
-- username will be the email address
CREATE TABLE ACCOUNT
(id					int					NOT NULL	IDENTITY(1,1),
first_name			varchar(20),
last_name			varchar(20)			NOT NULL,
username			varchar(20)			NOT NULL)

CREATE TABLE ACCOUNTPERMISSION
(id					int				NOT NULL	IDENTITY(1,1),
account_id			int				NOT NULL,
permission_id		tinyint			NOT NULL,
comment				varchar(255))

CREATE TABLE ARTICLE
(id					int				NOT NULL	IDENTITY(1,1),
title				varchar(255)	NOT NULL,
body				binary			NOT NULL)

CREATE TABLE ARTICLEHISTORY
(id					int				NOT NULL	IDENTITY(1,1),
article_id			int				NOT NULL,
account_id			int				NOT NULL,
body_history		binary			NOT NULL,
is_created			bit				NOT NULL	DEFAULT 0,
update_date			smalldatetime	NOT NULL)

CREATE TABLE ARTICLETAG
(id					int				NOT NULL	IDENTITY(1,1),
article_id			int				NOT NULL,
tag_id				int				NOT NULL)

CREATE TABLE ARTICLEVIEW
(id					int				NOT NULL	IDENTITY(1,1),
article_id			int				NOT NULL,
account_id			int				NOT NULL,
view_date			smalldatetime	NOT NULL)

CREATE TABLE PERMISSION
(id					tinyint			NOT NULL,
title				varchar(20)		NOT NULL,
is_administrator	bit				NOT NULL	DEFAULT 0,
is_valid			bit				NOT NULL	DEFAULT 1)

CREATE TABLE TAG
(id					int				NOT NULL	IDENTITY(1,1),
title				varchar(30)		NOT NULL)

GO

ALTER TABLE ACCOUNT
	ADD CONSTRAINT pk_account_id
	PRIMARY KEY (id)

ALTER TABLE ACCOUNTPERMISSION
	ADD CONSTRAINT pk_account_permission_id
	PRIMARY KEY (id)

ALTER TABLE ARTICLE
	ADD CONSTRAINT pk_article_id
	PRIMARY KEY (id)

ALTER TABLE ARTICLEHISTORY
	ADD CONSTRAINT pk_article_history_id
	PRIMARY KEY (id)

ALTER TABLE ARTICLETAG
	ADD CONSTRAINT pk_article_tag_id
	PRIMARY KEY (id)

ALTER TABLE ARTICLEVIEW
	ADD CONSTRAINT pk_article_review_id
	PRIMARY KEY (id)

ALTER TABLE PERMISSION
	ADD CONSTRAINT pk_permission_id
	PRIMARY KEY (id)

ALTER TABLE TAG
	ADD CONSTRAINT pk_tag_id
	PRIMARY KEY (id)

GO

ALTER TABLE ACCOUNTPERMISSION
	ADD

	CONSTRAINT fk_ap_account
	FOREIGN KEY (account_id) REFERENCES account (id),

	CONSTRAINT fk_ap_permission
	FOREIGN KEY (permission_id) REFERENCES permission (id)

ALTER TABLE ARTICLEHISTORY
	ADD
	
	CONSTRAINT fk_ah_article
	FOREIGN KEY (article_id) REFERENCES article (id),
	
	CONSTRAINT fk_ah_account
	FOREIGN KEY (account_id) REFERENCES account (id)
	
ALTER TABLE ARTICLETAG
	ADD
	
	CONSTRAINT at_article
	FOREIGN KEY (article_id) REFERENCES article (id),
	
	CONSTRAINT at_tag
	FOREIGN KEY (tag_id) REFERENCES tag (id)
	
ALTER TABLE ARTICLEVIEW
	ADD
	
	CONSTRAINT av_article
	FOREIGN KEY (article_id) REFERENCES article (id),
	
	CONSTRAINT av_account
	FOREIGN KEY (account_id) REFERENCES account (id)
	
GO

USE master