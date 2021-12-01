--------------------------------------------------------
--  ������ ������ - �����-12��-13-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ����
--------------------------------------------------------

  CREATE TABLE "PROJECTCHECK"."����" 
   (	"��������ȣ" CHAR(10), 
	"���̵�" CHAR(10), 
	"�̸�" VARCHAR2(20), 
	"�����̸�" VARCHAR2(20), 
	"�������" DATE, 
	"����ó" NUMBER(11,0), 
	"�ּ�" VARCHAR2(20), 
	"���ּ�" VARCHAR2(20), 
	"�Ҽ��а��ڵ�" CHAR(10)
   )
REM INSERTING into PROJECTCHECK."����"
SET DEFINE OFF;
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('001       ',null,'���ֿ�','MoonJuYoung',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('010       ',null,'������',null,null,null,null,null,'90        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('002       ','hong1     ','ȫ����','HongSungOk',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('003       ',null,'�ӿ���','LimWoongTack',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('004       ','core02    ','������','LimJeaYeong',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('005       ',null,'���ر�','KangJunGue',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('006       ',null,'������','KimYouWon',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('007       ',null,'�����','SeoDeaWon',null,null,null,null,'33        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('008       ',null,'�̸���','LeeMyongJae',null,null,null,null,'90        ');
Insert into PROJECTCHECK."����" ("��������ȣ","���̵�","�̸�","�����̸�","�������","����ó","�ּ�","���ּ�","�Ҽ��а��ڵ�") values ('009       ',null,'������',null,null,null,null,null,'90        ');
--------------------------------------------------------
--  DDL for Index ����_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTCHECK"."����_PK" ON "PROJECTCHECK"."����" ("��������ȣ")
--------------------------------------------------------
--  Constraints for Table ����
--------------------------------------------------------

  ALTER TABLE "PROJECTCHECK"."����" ADD CONSTRAINT "����_PK" PRIMARY KEY ("��������ȣ") ENABLE
  ALTER TABLE "PROJECTCHECK"."����" MODIFY ("��������ȣ" NOT NULL ENABLE)
