
CREATE TABLE public.category (
	id_category int4 NOT NULL,
	"name" varchar(100) NULL,
	CONSTRAINT category_pkey PRIMARY KEY (id_category)
);


-- public.purchase definition

-- Drop table

-- DROP TABLE public.purchase;

CREATE TABLE public.purchase (
	id_purchase int4 NOT NULL,
	CONSTRAINT purchase_pkey PRIMARY KEY (id_purchase)
);


-- public.product definition

-- Drop table

-- DROP TABLE public.product;

CREATE TABLE public.product (
	code varchar(20) NOT NULL,
	description varchar(500) NULL,
	"name" varchar(100) NULL,
	unit_cost float8 NULL,
	id_category int4 NULL,
	CONSTRAINT product_pkey PRIMARY KEY (code),
	CONSTRAINT fk_product_category_id FOREIGN KEY (id_category) REFERENCES category(id_category)
);


-- public.bill definition

-- Drop table

-- DROP TABLE public.bill;

CREATE TABLE public.bill (
	id_bill int4 NOT NULL,
	quantity int4 NULL,
	product varchar(20) NULL,
	CONSTRAINT bill_pkey PRIMARY KEY (id_bill),
	CONSTRAINT fk_product_bill FOREIGN KEY (product) REFERENCES product(code)
);


-- public.purchase_bill definition

-- Drop table

-- DROP TABLE public.purchase_bill;

CREATE TABLE public.purchase_bill (
	purchase_id_purchase int4 NOT NULL,
	bill_id_bill int4 NOT NULL,
	CONSTRAINT uk_c0hcq4od797lib8canktfxr6h UNIQUE (bill_id_bill),
	CONSTRAINT fk78oy2ut49d0d66b6v120gf7g0 FOREIGN KEY (bill_id_bill) REFERENCES bill(id_bill),
	CONSTRAINT fkmit8k3liis5uy16ln953fcp2d FOREIGN KEY (purchase_id_purchase) REFERENCES purchase(id_purchase)
);

