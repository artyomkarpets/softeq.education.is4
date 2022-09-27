# Information

## Project structure 

 - src - source code of backend microservices
 
 - postman - postman collection to test api 

## Source code 

 - Softeq.Education.TrialsSystem - main solution file that contains all projects
 
 ![image](https://user-images.githubusercontent.com/110222378/189868123-06f57fa4-b037-4caa-b5d0-9f254969c356.png)
 
 - docker-compose.yml (docker-compose.override.yml) - docker-compose file to start microservice
 

## Start project

For start user service you need to apply migration to SqlServer  
1. Start sql server

```
 docker-compose up sqlserver -d
 
```
2. Create TS_Users database

![image](https://user-images.githubusercontent.com/110222378/192443790-3f7fca6a-3da0-4489-9c38-719b0e31a581.png)

2. Open TrialSystem.UsersService.sln

3. Run command  Update-Database

![image](https://user-images.githubusercontent.com/110222378/192443974-b88555f3-ce3f-4682-9541-38a8c65e61be.png)

4. Check DB 

![image](https://user-images.githubusercontent.com/110222378/192444097-d7d8515b-743f-487a-93fe-890043ccadc5.png)
