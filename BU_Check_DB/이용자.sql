--------------------------------------------------------
--  ������ ������ - �����-12��-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table �̿���
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."�̿���" 
   (	"���̵�" CHAR(10), 
	"��й�ȣ" VARCHAR2(20), 
	"����" VARCHAR2(20)
   )
REM INSERTING into PROJECTCHECK."�̿���"
SET DEFINE OFF;
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('admin     ','admin','������');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('hong1     ','1111','����');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('core02    ','1111','����');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('Yongmin   ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('777ymca   ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('dong      ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('JeongHo   ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('yj        ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('KyungBin  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('WonBum    ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('SeokHyun  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('BeomGi    ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('1StdB     ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong1  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong2  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong3  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong4  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong5  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('GilDong6  ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('1StdA     ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('2StdA     ','1234','�л�');
Insert into PROJECTCHECK."�̿���" ("���̵�","��й�ȣ","����") values ('3StdB     ','1234','�л�');
--------------------------------------------------------
--  DDL for Index �̿���_PK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."�̿���_PK1" ON "PROJECTCHECK"."�̿���" ("���̵�")
--------------------------------------------------------
--  Constraints for Table �̿���
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."�̿���" ADD CONSTRAINT "�̿���_PK" PRIMARY KEY ("���̵�") ENABLE
  ALTER TABLE "PROJECTCHECK"."�̿���" MODIFY ("���̵�" NOT NULL ENABLE)
