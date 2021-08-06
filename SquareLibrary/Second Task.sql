CREATE TABLE product
(
    product_id integer NOT NULL,
    product_name varchar(32) NOT NULL,
    primary key (product_id)
)
CREATE TABLE category
(
    category_id integer NOT NULL,
    category_name varchar(32) NOT NULL,
    primary key (category_id)
)
CREATE TABLE product_category
(
    product_id integer NOT NULL,
    category_id integer  NOT NULL,
    PRIMARY KEY (product_id , category_id ),
    FOREIGN KEY (product_id) REFERENCES product,
    FOREIGN KEY (category_id ) REFERENCES category,
);

 select product.product_name, category.category_name
 from product_category
    join category on category.category_id=product_category.category_id
    full join product on product.product_id=product_category.product_id