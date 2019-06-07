For this part we'll consider that the base url is : http://localhost:8080/apiV1/
<br>
The "root" resource is books
<br>
The "child" resource is authors
<br>
For each case we have a corresponding API diagram

# Root Route :
![Root API Model](https://github.com/synodetechnologies/Ribosome/blob/master/img/url_endpoint_books.JPG)
+ Get : [base url]/books/{book_id} - http verb : GET
+ List : [base url]/books/ - http verb : GET
+ Create : [base url]/books/ - http verb : POST
+ Update : [base url]/books/{book_id} - http verb : PUT
+ Delete : [base url]/books/{book_id} - http verb : DELETE

## Derived Route RootRef :
![Root API Model and his Ref class](https://github.com/synodetechnologies/Ribosome/blob/master/img/url_endpoint_booksref.JPG)
+ **Relation 1<>***
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id} - http verb : GET
  + List : [base url]/another_root_resource/{id}/[...]/books/ - http verb : GET
+ **Relation 1<>1**
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id} - http verb : GET
+ **Relation 1<>0..1**
  + GetByID : [base url]/another_root_resource/{id}/[...]/books/{book_id} - http verb : GET
  
# Children Route Relations
##  Normal Children Route :
![API Model](https://github.com/synodetechnologies/Ribosome/blob/master/img/url_endpoint_books_authors.JPG)
+ **Relation 1<>***
  + GetByID : [base url]/books/{book_id}/authors/{author_id} - http verb : GET
  + List : [base url]/books/{book_id}/authors/ - http verb : GET
  + Create : [base url]/books/{book_id}/authors/ - http verb : POST
  + Update : [base url]/books/{book_id}/authors/{author_id} - http verb : PUT
  + Delete : [base url]/books/{book_id}/authors/{author_id} - http verb : DELETE
+ **Relation 1<>1**
  + GetByID : [base url]/books/{book_id}/authors/{author_id} - http verb : GET
  + Update : [base url]/books/{book_id}/authors/{author_id} - http verb : PUT
+ **Relation 1<>0.1**
  + GetByID : [base url]/books/{book_id}/authors/{author_id} - http verb : GET
  + Create : [base url]/books/{book_id}/authors/ - http verb : GET
  + Update : [base url]/books/{book_id}/authors/{author_id} - http verb : PUT
  + Delete : [base url]/books/{book_id}/authors/{author_id} - http verb : DELETE
      
## Ref Children Route :
![API Model](https://github.com/synodetechnologies/Ribosome/blob/master/img/url_endpoint_book_childref.JPG)
+ **Relation 1<>***
  + Add : [base url]/books/{book_id}/authors/{author_id} - http verb : POST
  + Remove : [base url]/books/{book_id}/authors/{author_id} - http verb : DELETE
+ **Relation 1<>1**
  + Replace : [base url]/books/{book_id}/authors/{author_id} - http verb : POST
+ **Relation 1<>0..1**
  + Replace : [base url]/books/{book_id}/authors/{author_id} - http verb : POST
  + Clear : [base url]/books/{book_id}/authors/{author_id} - http verb : DELETE

*N.B.* : Repeat Child Relations pattern for GrandChildren and so on
