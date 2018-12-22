select * from person;

insert into person (first_name, last_name , national_id, age)
values	
('ali', 'alipour' , 11111 , 20),
('akbar' , 'akbari' , 11112 , 21),
('ahmad' , 'ahmadi' , 11113 , 20),
('reza' , 'rezaei' , 11114 , 22);

insert into student (person_id , student_number)
values 
(3 , 14147 ) ,
(4 , 159753 );

select * from student;

select person.id , person.first_name , person.last_name ,
student.student_number from student full join person
on student.person_id = person.id;