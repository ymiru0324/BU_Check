--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table 학과
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."학과" 
   (	"학과코드" CHAR(10), 
	"학과명" CHAR(30)
   )
REM INSERTING into PROJECTCHECK."학과"
SET DEFINE OFF;
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('90        ','교양과                     ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('50        ','아동복지과               ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('33        ','컴퓨터소프트웨어학과');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('99        ','행정과                     ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('49        ','아동보육과               ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('18        ','유아교육과               ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('48        ','간호학과                  ');
Insert into PROJECTCHECK."학과" ("학과코드","학과명") values ('34        ','컴퓨터정보보안학과   ');
--------------------------------------------------------
--  DDL for Index 학과_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."학과_PK" ON "PROJECTCHECK"."학과" ("학과코드")
--------------------------------------------------------
--  Constraints for Table 학과
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."학과" ADD CONSTRAINT "학과_PK" PRIMARY KEY ("학과코드") ENABLE
  ALTER TABLE "PROJECTCHECK"."학과" MODIFY ("학과코드" NOT NULL ENABLE)
