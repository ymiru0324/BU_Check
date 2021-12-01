--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table 관리자
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."관리자" 
   (	"교직원번호" CHAR(10), 
	"아이디" CHAR(10), 
	"이름" VARCHAR2(20), 
	"영문이름" VARCHAR2(20), 
	"생년월일" DATE, 
	"연락처" NUMBER(11,0), 
	"주소" VARCHAR2(20), 
	"상세주소" VARCHAR2(20), 
	"소속학과코드" CHAR(10)
   )
REM INSERTING into PROJECTCHECK."관리자"
SET DEFINE OFF;
Insert into PROJECTCHECK."관리자" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('999       ','admin     ','관리자','adminator',null,null,null,null,'99        ');
--------------------------------------------------------
--  DDL for Index 관리자_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."관리자_PK" ON "PROJECTCHECK"."관리자" ("교직원번호")
--------------------------------------------------------
--  Constraints for Table 관리자
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."관리자" ADD CONSTRAINT "관리자_PK" PRIMARY KEY ("교직원번호") ENABLE
  ALTER TABLE "PROJECTCHECK"."관리자" MODIFY ("교직원번호" NOT NULL ENABLE)
