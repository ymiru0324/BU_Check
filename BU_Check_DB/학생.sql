--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table 학생
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."학생" 
   (	"학번" CHAR(10), 
	"아이디" CHAR(10), 
	"이름" VARCHAR2(20), 
	"영문이름" VARCHAR2(20), 
	"학년" VARCHAR2(20), 
	"반" VARCHAR2(20), 
	"생년월일" DATE, 
	"연락처" NUMBER(11,0), 
	"주소" VARCHAR2(20), 
	"상세주소" VARCHAR2(20), 
	"소속학과코드" CHAR(10)
   )
REM INSERTING into PROJECTCHECK."학생"
SET DEFINE OFF;
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1633008   ','777ymca   ','김현우','KimHyunWoo','2','B',to_date('97/06/23','RR/MM/DD'),1067656232,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1633031   ','Yongmin   ','김용민','KimYongMin','2','B',to_date('97/03/24','RR/MM/DD'),1023411234,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1633009   ','dong      ','강동현','KangDongHyun','2','B',to_date('97/11/23','RR/MM/DD'),1031233123,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('0000000   ',null,'출석맨',null,null,null,null,null,null,null,'99        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1733001   ','JeongHo   ','신정호','JeongHo','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433056   ','yj        ','이용정','YongJeong ','2','B',null,100101011,'인천시','구월동','33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433002   ','KyungBin  ','김경빈','KyungBin  ','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433003   ','WonBum    ','김원범','WonBum    ','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1533001   ','SeokHyun  ','박석현','SeokHyun  ','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433004   ','BeomGi    ','민범기','BeomGi    ','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1633001   ',null,'일학에','test','1','A',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433005   ',null,'홍길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1433006   ',null,'김길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1733004   ',null,'박길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1733022   ',null,'최길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1733033   ',null,'서길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1733006   ',null,'이길동','Gil Dong','2','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1633002   ',null,'일학비','test','1','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1533011   ',null,'삼학비','test','3','B',null,100101011,null,null,'33        ');
Insert into PROJECTCHECK."학생" ("학번","아이디","이름","영문이름","학년","반","생년월일","연락처","주소","상세주소","소속학과코드") values ('1533022   ',null,'이학에','test','2','A',null,100101011,null,null,'33        ');
--------------------------------------------------------
--  DDL for Index 학생_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."학생_PK" ON "PROJECTCHECK"."학생" ("학번")
--------------------------------------------------------
--  Constraints for Table 학생
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."학생" ADD CONSTRAINT "학생_PK" PRIMARY KEY ("학번") ENABLE
  ALTER TABLE "PROJECTCHECK"."학생" MODIFY ("학번" NOT NULL ENABLE)
