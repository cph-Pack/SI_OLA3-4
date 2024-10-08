# SI_OLA3-4

## Remote Event Storming Session
We had a remote event storming session following this [guide](https://ddd-practitioners.com/2023/03/20/remote-eventstorming-workshop/) and we documented our workshop and the different steps. 

To start with we explored the domain in an unstructured way and produced this:
![image](https://github.com/user-attachments/assets/f736a8b6-503c-4ac7-9457-590575d91751)

Then we added sequence to the events and discussed our questions, which we added to illustrate like so:
![image](https://github.com/user-attachments/assets/fddd0899-dd5d-41ab-9664-40274dd0ac14)

Then we identified the pivotal events, which we believe are these:
![image](https://github.com/user-attachments/assets/f7823259-db7b-4c1c-a924-9ad0eea25e88)

We identified the actors and their commands:
![image](https://github.com/user-attachments/assets/10399b42-e843-425a-851c-e6a3e533c1ce)

And identified the policies and business invariants:
![image](https://github.com/user-attachments/assets/69f13cd5-2764-4723-8b67-1eed9cbfaa0a)

We decided that payment will not be in our scope and instead be handled through an external system: 
![image](https://github.com/user-attachments/assets/9e43de83-2b7d-4610-ba26-983f9ea51868)

Then we identified the read models:
![image](https://github.com/user-attachments/assets/2489642b-1929-4de9-b484-56bbff39b8e3)

And found the aggregates and their bounded context:

![image](https://github.com/user-attachments/assets/dce973db-572d-4ad0-ae11-05e2c75178a7)

![image](https://github.com/user-attachments/assets/46c71264-a652-4940-b524-5e4fc712a4a1)

![image](https://github.com/user-attachments/assets/39060e47-2953-4d9c-9a57-942aaefdf913)



### Creating C4 diagrams
After our event storming session, we started on creating some C4 diagrams.
Level 1 - Context diagram:
![image](https://github.com/user-attachments/assets/252a9270-03f6-4ee4-a24f-952fdd829ed5)

Level 2 - Container diagram:
![image](https://github.com/user-attachments/assets/6000fea5-aa2e-4e6c-bf32-21bcc44e8787)

Level 3 - Component diagram:
![image](https://github.com/user-attachments/assets/fb084b6a-4bf0-40a0-aa7a-fe9630e36017)

### Ubiqutous language
We recognized the following words as essiential to our case.\
**Trailer** - The trailers are owned by MyTrailer and are identified by a location id and a number.\
**Users / Customers** - The individuals who rent trailers. The two terms are used interchangeably.\
**Owner / MyTrailer** - The primary owner of the trailers and the MyTrailer booking system.\
**Locations** - A physical place where the trailers can be picked up by the users. The location is identified by a location id.\
**Specialist location** - A type of location where the customer can pick up specifically the trailers rented for a period beyond 24 hours.\
**Branding** - The iconography of the MyTrailer business and partner companies on the trailers.\
**Partner Companies / Partners** - Separate business that provide the locations for the trailers to be parked in exchange for branding on the trailers and pay MyTrailer for the rental service.\
**Mobile app** - An application for mobile devices, where the customer can make short term rentals of trailers.\
**Booking** - The act of reserving a trailer.\
**Short term rental** - A booking which is completed before 00:00 the day it was rented.\
**Long term rental** - A booking which is completed earliest the day after the booking of the trailer has occurred, only available through the website.\
**Website** - A site on the internet where the customer can make short- and long term rentals of trailers.\
**Excess rental fee** - A penalty fee applied to the price of renting a trailer when the maximum rental period is exceeded.\
**Rental insurance** - Insurance for a trailer covering any damages, caused by fair usage, that may occur during the rental period.\
**Fair usage** -  A legal contract which shows in detail what kind of damage will be covered by the rental insurance fee. All customers must sign that they read and understand the terms before renting a trailer.










