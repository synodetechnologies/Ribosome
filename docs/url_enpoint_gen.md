# Root Class :
+ Get  
+ List
+ Create
+ Update
+ Delete

## Derived Root Class :
+ **Relation 1<>***
  + GetByID
  + List
+ **Relation 1<>1**
  + GetByID
+ **Relation 1<>0..1**
  + GetByID
  
# Child Relations
##  Normal Child Class :
+ **Relation 1<>***
  + Get
  + List
  + Create
  + Update
  + Delete
+ **Relation 1<>1**
  + Get
  + Update
+ **Relation 1<>0.1**
  + Get
  + Create
  + Update
  + Delete
      
## Derived Child Class :
+ **Relation 1<>***
  + Add
  + Remove
+ **Relation 1<>1**
  + Replace
+ **Relation 1<>0..1**
  + Replace
  + Clear

*N.B.* : Repeat Child Relations pattern for GrandChildren and so on
