For this part we'll consider that the base url is : http://localhost:8080/apiV1/
The "root" resource is books
The "child" resource is authors

# Root Class :
+ Get : [base url]/books/{book_id}   
+ List : [base url]/books/
+ Create : [base url]/books/
+ Update : [base url]/books/{book_id}
+ Delete : [base url]/books/{book_id}

## Derived Root Class :
+ **Relation 1<>***
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id}
  + List : [base url]/another_root_resource/{id}/[...]/books/
+ **Relation 1<>1**
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id}
+ **Relation 1<>0..1**
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id}
  
# Child Relations
##  Normal Child Class :
+ **Relation 1<>***
  + GetByID : [base url]/books/{book_id}/authors/{author_id}
  + List : [base url]/books/{book_id}/authors/
  + Create : [base url]/books/{book_id}/authors/
  + Update : [base url]/books/{book_id}/authors/{author_id}
  + Delete : [base url]/books/{book_id}/authors/{author_id}
+ **Relation 1<>1**
  + GetByID : [base url]/books/{book_id}/authors/{author_id}
  + Update : [base url]/books/{book_id}/authors/{author_id}
+ **Relation 1<>0.1**
  + GetByID : [base url]/books/{book_id}/authors/{author_id}
  + Create : [base url]/books/{book_id}/authors/
  + Update : [base url]/books/{book_id}/authors/{author_id}
  + Delete : [base url]/books/{book_id}/authors/{author_id}
      
## Derived Child Class :
+ **Relation 1<>***
  + Add : [base url]/books/{book_id}/authors/{author_id}
  + Remove : [base url]/books/{book_id}/authors/{author_id}
+ **Relation 1<>1**
  + Replace : [base url]/books/{book_id}/authors/{author_id}
+ **Relation 1<>0..1**
  + Replace : [base url]/books/{book_id}/authors/{author_id}
  + Clear : [base url]/books/{book_id}/authors/{author_id}

*N.B.* : Repeat Child Relations pattern for GrandChildren and so on
