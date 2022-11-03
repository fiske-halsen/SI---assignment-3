# Integration Task 3 - API's
## Installation and usage
To run the program install docker and visual studio 2022

In both Docker-Book-Db and Docker-School-Db directories run ```docker-compose up -d``` in a terminal to start the two database instances.\
Now open visual studio, right-click the soulution project, and click set startup projects.\
Now click multiple startup projects, and select alt three projects.\
Now run the program. Two servers will open in your browser, one handling students, and one handling books.\  
Use them as you wish. 

If you want to fill the databases up with dummy data, run ```update-database``` from the package-manager-console for both the SchoolAPI and the GrpcService. 

You are able to get a book recommendation for a student, given their budget and subjects (or both).\
The SchoolAPI communicates directly with a database, while the BookAPI communicates with our Grpc service, that then communicates with the database. We've made a simple diagram to describe this:

![Alt text](Diagram/system/?raw=true "Title")