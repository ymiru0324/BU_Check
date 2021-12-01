--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table 이용자
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."이용자" 
   (	"아이디" CHAR(10), 
	"비밀번호" VARCHAR2(20), 
	"권한" VARCHAR2(20)
   )
REM INSERTING into PROJECTCHECK."이용자"
SET DEFINE OFF;
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('admin     ','admin','관리자');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('hong1     ','1111','교수');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('core02    ','1111','교수');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('Yongmin   ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('777ymca   ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('dong      ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('JeongHo   ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('yj        ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('KyungBin  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('WonBum    ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('SeokHyun  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('BeomGi    ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('1StdB     ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong1  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong2  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong3  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong4  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong5  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('GilDong6  ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('1StdA     ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('2StdA     ','1234','학생');
Insert into PROJECTCHECK."이용자" ("아이디","비밀번호","권한") values ('3StdB     ','1234','학생');
--------------------------------------------------------
--  DDL for Index 이용자_PK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."이용자_PK1" ON "PROJECTCHECK"."이용자" ("아이디")
--------------------------------------------------------
--  Constraints for Table 이용자
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."이용자" ADD CONSTRAINT "이용자_PK" PRIMARY KEY ("아이디") ENABLE
  ALTER TABLE "PROJECTCHECK"."이용자" MODIFY ("아이디" NOT NULL ENABLE)
