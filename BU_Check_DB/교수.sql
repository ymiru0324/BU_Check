--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table 교수
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."교수" 
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
REM INSERTING into PROJECTCHECK."교수"
SET DEFINE OFF;
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('001       ',null,'문주영','MoonJuYoung',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('010       ',null,'임정혁',null,null,null,null,null,'90        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('002       ','hong1     ','홍성옥','HongSungOk',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('003       ',null,'임웅택','LimWoongTack',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('004       ','core02    ','임제영','LimJeaYeong',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('005       ',null,'강준규','KangJunGue',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('006       ',null,'김유원','KimYouWon',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('007       ',null,'서대원','SeoDeaWon',null,null,null,null,'33        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('008       ',null,'이명재','LeeMyongJae',null,null,null,null,'90        ');
Insert into PROJECTCHECK."교수" ("교직원번호","아이디","이름","영문이름","생년월일","연락처","주소","상세주소","소속학과코드") values ('009       ',null,'전종현',null,null,null,null,null,'90        ');
--------------------------------------------------------
--  DDL for Index 교수_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."교수_PK" ON "PROJECTCHECK"."교수" ("교직원번호")
--------------------------------------------------------
--  Constraints for Table 교수
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."교수" ADD CONSTRAINT "교수_PK" PRIMARY KEY ("교직원번호") ENABLE
  ALTER TABLE "PROJECTCHECK"."교수" MODIFY ("교직원번호" NOT NULL ENABLE)
