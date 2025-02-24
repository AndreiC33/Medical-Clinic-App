# Medical-Clinic-App
This project is a windows forms application in C# that I developed in Visual Studio IDE. The Database was created using Microsoft SQL Server

The scope of this application is to be used by three entities:patients, doctors and the administrator. Each one has a different User experience while using the app.

Firstly, as a patient, you are met with a Login page where you should enter your credentials. If you are using the app for the first time, you can click the "Create account"
button to create an account and you will be sent to another form where you should fill out all the textboxes with your data. After that, you will be met with another form where 
you can choose a doctor and make an appoinment at a specified date and time. You also have a Patient History as you keep making appoinments. You can cancel appoinments if you decide to do that.

As a doctor, your credentials are stored in the Database by the administrator so you fill the login form with you information and be directed to another form with upcoming appoinments that the 
patients made and you can cancel them if you want.

As the administrator,you have access to both tables of all the doctors and their specialties and all of the Patients that made an account to the application and can make changes if needed.
