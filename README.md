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

![image](https://github.com/user-attachments/assets/57589e83-a266-4d82-9917-909ca5b9c340)


### Creating C4 diagrams
After our event storming session, we started on creating some C4 diagrams.
Level 1 - Context diagram:
![image](https://github.com/user-attachments/assets/252a9270-03f6-4ee4-a24f-952fdd829ed5)

Level 2 - Container diagram:
![image](https://github.com/user-attachments/assets/6000fea5-aa2e-4e6c-bf32-21bcc44e8787)

Level 3 - Component diagram:
![image](https://github.com/user-attachments/assets/fb084b6a-4bf0-40a0-aa7a-fe9630e36017)



