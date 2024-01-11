Prerequiste:
MSSQL Server, .NetCore 5, angular 8
Steps for setup repository in your local machine
1. Clone repository
2. Update appsettings.json Connections with local db credentials.
3. Open Package-Manager Console and type Update-Database
4. Let migration happen. Once command complete, connect to localdb and verify database "SamplePOC" present. Also verify tables Countries, ExchangeRate and Products.If any error comes refer step 5 else refer step 6.
5. If there is any problem occurs in migration step please run Add-Migration <<Migration_name>> and then Update-database.
6. After migration run below insert query commands to have predefined data.You can add data according to your choice also.
   use samplePOC
   insert into Products values( 'TV', 'A brand new TV', 1);
   insert into Products values('Fridge','abc',10);
   insert into Products values('TV2', 'A brand new TV', 15);
   insert into Products values( 'Fridge2','abc',20);
   insert into Products values( 'TV3', 'A brand new TV', 25);
   insert into Countries values( 'United States','UK','GBP');
   insert into Countries values ('United States','US','USD');
   insert into countries values('Germany','DE','EUR');
   insert into ExchangeRates values(1.28,'USD','2024-01-01',null);
   insert into ExchangeRates values(1.00,'GBP','2024-01-01',null);
   insert into ExchangeRates values(1.16,'EUR','2024-01-01',null);

Please note Products table has cost in GBP.

7.Launch application.


![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/cb56f7a1-45b9-42e2-be80-4415228d23da)
![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/b884b08b-5aa0-4755-b345-89275200b811)

![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/9e3c0996-5e98-4433-872b-16f86a7e2a73)
![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/2ce050c2-764d-48ba-a8e2-8a990807a84b)
![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/2c0e59df-c81f-4010-b455-8c5255eb42a7)
![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/ca950a27-36f0-4011-90fd-f639d5da6320)
![image](https://github.com/Mirnal1409/sample-poc-project/assets/30199522/74e957ca-9677-469b-a642-f37a0ddcb342)






   
