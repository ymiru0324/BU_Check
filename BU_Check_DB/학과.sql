--------------------------------------------------------
--  ������ ������ - �����-12��-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table �а�
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."�а�" 
   (	"�а��ڵ�" CHAR(10), 
	"�а���" CHAR(30)
   )
REM INSERTING into PROJECTCHECK."�а�"
SET DEFINE OFF;
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('90        ','�����                     ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('50        ','�Ƶ�������               ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('33        ','��ǻ�ͼ���Ʈ�����а�');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('99        ','������                     ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('49        ','�Ƶ�������               ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('18        ','���Ʊ�����               ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('48        ','��ȣ�а�                  ');
Insert into PROJECTCHECK."�а�" ("�а��ڵ�","�а���") values ('34        ','��ǻ�����������а�   ');
--------------------------------------------------------
--  DDL for Index �а�_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."�а�_PK" ON "PROJECTCHECK"."�а�" ("�а��ڵ�")
--------------------------------------------------------
--  Constraints for Table �а�
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."�а�" ADD CONSTRAINT "�а�_PK" PRIMARY KEY ("�а��ڵ�") ENABLE
  ALTER TABLE "PROJECTCHECK"."�а�" MODIFY ("�а��ڵ�" NOT NULL ENABLE)
