USE MASTER
GO
DROP DATABASE db_library;
GO
CREATE DATABASE db_library;
GO
USE db_library
GO

CREATE TABLE tbl_book (
	book_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	book_title VARCHAR(50) NOT NULL,
	publisher_name VARCHAR(50) FOREIGN KEY REFERENCES tbl_publisher(publisher_name)
);

INSERT INTO tbl_book 
	(book_title, publisher_name)
	VALUES
	('the shining', 'doubleday'),
	('the dark tower', 'scribner'),
	('the lost tribe','picador'),
	('foucaults pendulum', 'bompiani'),
	('dune', 'chilton'),
	('the warrior prophet', 'overlook press'),
	('harry potter', 'bloomsberry'),
	('blindsight', 'tor'),
	('enders game', 'tor'),
	('the long walk', 'new american library'),
	('salems lot', 'doubleday'),
	('anathem', 'william morrow and company'),
	('the face', 'bantam books'),
	('a game of thrones', 'bantam spectra'),
	('a clash of kings', 'bantam spectra'),
	('allegiant', 'collins pub'),
	('insurgent', 'collins pub'),
	('the hunger games', 'scholastic corporation'),
	('ready player one', 'random house'),
	('the rainman', 'addison wesley'),
	('the client', 'doubleday')
;

CREATE TABLE tbl_author (
	book_id INT FOREIGN KEY  REFERENCES tbl_book(book_id),
	author_name VARCHAR(50) NOT NULL,
	
);

INSERT INTO tbl_author
	(book_id, author_name)
	VALUES
	('1', 'stephen king'),
	('2', 'stephen king'),
	('3', 'mathew caldwell'),
	('4', 'umberto eco'),
	('5', 'frank herbert'),
	('6', 'r. scott baakker'),
	('7', 'j. k. rowlings'),
	('8', 'peter watts'),
	('9', 'orson scott card'),
	('10', 'stephen king'),
	('11', 'stephen king'),
	('12', 'neal stephenson'),
	('13','dean koontz'),
	('14', 'george r. r. martin'),
	('15', 'george r. r. martin'),
	('16', 'veronica roth'),
	('17', 'veronica roth'),
	('18', 'suzanne collins'),
	('19', 'ernest cline'),
	('20', 'john grisham'),
	('21', 'john grisham')
;




CREATE TABLE tbl_publisher (
	publisher_name VARCHAR(50) PRIMARY KEY NOT NULL,
	publisher_address VARCHAR(50) NOT NULL,
	publisher_phone VARCHAR(50) NOT NULL
);

INSERT INTO tbl_publisher
	(publisher_name, publisher_address, publisher_phone)
	VALUES
	('doubleday','new york','852-2845'),
	('scribner', 'virginia', '851-2310'),
	('picador', 'chicago', '435-7829'),
	('bompiani', 'omaha', '789-2645'),
	('chilton', 'los angeles', '147-7825'),
	('overlook press', 'san diego', '183-9823'),
	('bloomsberry', 'ontario', '658-4564'),
	('tor', 'new york', '852-1400'),
	('new american library', 'seattle', '324-4567'),
	('william morrow and company', 'dallas', '657-8541'),
	('bantam books', 'new jersey', '854-6528'),
	('bantam spectra', 'tampa', '232-5479'),
	('collins pub', 'austin', '846-4578'),
	('scholastic corporation', 'milwaukee', '984-5467'),
	('random house', 'los angeles', '321-5491' ),
	('addison wesley', 'dallas', '658-9475')
;
 
CREATE TABLE tbl_loans (
	book_id INT FOREIGN KEY REFERENCES tbl_book(book_id),
	branch_id INT FOREIGN KEY REFERENCES tbl_branch(branch_id),
	card_number INT FOREIGN KEY REFERENCES tbl_borrower(card_number),
	date_out VARCHAR (50) NOT NULL,
	due_date VARCHAR(50) NOT NULL
);

INSERT INTO tbl_loans
	(book_id, branch_id, card_number, date_out, due_date)
	VALUES
	('1','1','1','5/4/2018', '6/4/2018'),
	('2','1','1', '5/5/2018', '6/5/2018'),
	('3', '2', '1', '5/6/2018', '6/6/2018'),
	('4', '2', '1', '5/7/2018', '6/7/2018'),
	('5', '4', '1', '5/8/2018', '6/8/2018'),
	('6', '3', '1', '5/9/2018', '6/9/2018'),
	('7','4','1', '5/10/2018', '6/10/2018'),
	('8','1', '1', '5/11/2018', '6/11/2018'),
	('9', '3', '5', '5/12/2018', '6/12/2018'),
	('10', '2', '6', '5/13/2018', '6/13/2018'),
	('11', '4', '7', '5/14/2018', '6/14/2018'),
	('12', '3', '8','5/15/2018', '6/15/2018'),
	('13', '2', '8', '5/16/2018', '6/16/2018'),
	('14', '4', '8', '5/17/2018', '6/17/2018'),
	('15', '3', '5', '5/18/2018', '6/18/2018'),
	('16', '4','6', '5/19/2018', '6/19/2018'),
	('17', '1','7', '5/20/2018', '6/20/2018'),
	('18', '3', '8', '5/21/2018', '6/21/2018'),
	('19', '2', '5', '5/22/2018', '6/22/2018'),
	('20', '4', '6', '5/23/2018', '6/23/2018'),
	('21', '1', '7', '5/24/2018', '6/24/2018'),
	('1','2','3', '5/25/2018', '6/25/2018'),
	('2','2','3', '5/26/2018', '6/26/2018'),
	('3', '1', '3', '5/27/2018', '6/27/2018'),
	('4', '1', '3', '5/28/2018', '6/28/2018'),
	('5', '3', '3', '5/28/2018', '6/28/2018'),
	('6', '4', '3', '5/29/2018', '6/29/2018'),
	('7','3','3', '5/29/2018', '6/29/2018'),
	('8','2', '3', '5/29/2018', '6/29/2018'),
	('9', '4', '4', '5/29/2018', '6/29/2018'),
	('10', '1', '4', '5/29/2018', '6/29/2018'),
	('11', '3', '4', '5/30/2018', '6/30/2018'),
	('12', '4', '4', '5/30/2018', '6/30/2018'),
	('13', '1', '4', '5/30/2018', '6/30/2018'),
	('14', '3', '4', '5/30/2018', '6/30/2018'),
	('15', '4', '4', '6/1/2018', '7/1/2018'),
	('16', '3','4', '6/1/2018', '7/1/2018'),
	('17', '2','4', '6/1/2018', '7/1/2018'),
	('18', '4', '4', '6/1/2018', '7/1/2018'),
	('19', '1', '4', '6/1/2018', '7/1/2018'),
	('20', '3', '4', '6/1/2018', '7/1/2018'),
	('21', '2', '4', '6/1/2018', '7/1/2018'),
	('1','1','2', '6/2/2018', '7/2/2018'),
	('2','1','2', '6/2/2018', '7/2/2018'),
	('3', '2', '2', '6/2/2018', '7/2/2018'),
	('4', '2', '2', '6/2/2018', '7/7/2018'),
	('5', '4', '2', '6/2/2018', '7/2/2018'),
	('6', '3', '2', '6/2/2018', '7/9/2018'),
	('7','4','2', '6/2/2018', '7/8/2018'),
	('8','1', '2', '6/2/2018', '7/8/2018')
;




CREATE TABLE tbl_copies (
	book_id INT FOREIGN KEY REFERENCES tbl_book(book_id),
	branch_id INT FOREIGN KEY REFERENCES tbl_branch(branch_id),
	No_Of_Copies INT NOT NULL
);


INSERT INTO tbl_copies
	(book_id, branch_id, No_Of_Copies)
	VALUES	
	('1','1','15'),
	('2','1','13'),
	('3', '2', '9'),
	('4', '2', '6'),
	('5', '4', '8'),
	('6', '3', '9'),
	('7','4','15'),
	('8','1', '13'),
	('9', '3', '9'),
	('10', '2', '6'),
	('11', '4', '8'),
	('12', '3', '9'),
	('13', '2', '6'),
	('14', '4', '8'),
	('15', '3', '9'),
	('16', '4','15'),
	('17', '1','13'),
	('18', '3', '9'),
	('19', '2', '6'),
	('20', '4', '8'),
	('21', '1', '9'),
	('1','2','15'),
	('2','2','13'),
	('3', '1', '9'),
	('4', '1', '6'),
	('5', '3', '8'),
	('6', '4', '9'),
	('7','3','15'),
	('8','2', '13'),
	('9', '4', '9'),
	('10', '1', '6'),
	('11', '3', '8'),
	('12', '4', '9'),
	('13', '1', '6'),
	('14', '3', '8'),
	('15', '4', '9'),
	('16', '3','15'),
	('17', '2','13'),
	('18', '4', '9'),
	('19', '1', '6'),
	('20', '3', '8'),
	('21', '2', '9')
;





CREATE TABLE tbl_borrower (
	card_number INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	borrower_name VARCHAR(50) NOT NULL,
	borrower_address VARCHAR(50) NOT NULL,
	borrower_phone VARCHAR(50) NOT NULL,
);

INSERT INTO tbl_borrower
	(borrower_name, borrower_address, borrower_phone)
	VALUES
	('flag', '120 s 1800 e','852-2121'),
	('katniss', ' 130 s 1600 e','852-2134'),
	('beatrice', '124 s 1830 e','851-2121'),
	('harry', ' 160 s 1900 e','435-0943'),
	('achamian', '120 n 1800 w', '984-3214'),
	('tina fey', ' 130 n 1600 w', '931-2391'),
	('ender', '120 s 1800 e', '213-6453'),
	('john', ' 140 s 1800 w' ,'429-5463')
;




CREATE TABLE tbl_branch (
	branch_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	branch_name VARCHAR(50) NOT NULL,
	branch_address VARCHAR(50) NOT NULL
);

INSERT INTO tbl_branch 
	(branch_name, branch_address)
	VALUES
	('sharpstown', '180 n state st, new york city'),
	('central', '250 s state st, new york city'),
	('seaside', '200 s main st, new york city'),
	('richmond', '100 n main st, new york city')
;

SELECT * from tbl_author;
select * FROM tbl_book;

SELECT * FROM tbl_publisher;
SELECT * FROm tbl_branch;
SELECT * FROM tbl_loans;

/* stored proc 1*/

SELECT a1.No_Of_Copies
	 FROM tbl_copies a1
	 INNER JOIN tbl_branch a2 ON a2.branch_id = a1.branch_id
	 INNER JOIN tbl_book a3 ON a3.book_id = a1.book_id
	 WHERE a3.book_id = 3 and a2.branch_id = 1;

/* stored proc 2*/
 SELECT a1.No_Of_Copies
	 FROM tbl_copies a1
	 INNER JOIN tbl_branch a2 ON a2.branch_id = a1.branch_id
	 INNER JOIN tbl_book a3 ON a3.book_id = a1.book_id
	 WHERE a3.book_id = 3;

 /*stored proc 3 HELP*/
 SELECT a1.borrower_name
	FROM tbl_borrower a1
	FULL OUTER JOIN tbl_loans a2 ON a2.card_number = a1.card_number
	WHERE a2.card_number IS NULL
;


/*stored proc 4*/

SELECT a3.book_title, a2.borrower_name, a2.borrower_address
	FROM tbl_loans a1
	INNER JOIN tbl_borrower a2 ON a2.card_number = a1.card_number
	INNER JOIN tbl_book a3 ON a3.book_id = a1.book_id
	INNER JOIN tbl_branch a4 ON a4.branch_id = a1.branch_id
	WHERE a4.branch_id = 1 and due_date = CONVERT(date, GETDATE())
;


/*stored proc 5*/


SELECT COUNT (a2.book_id) AS "number of books checked out", a1.branch_name
	FROM tbl_branch a1
	INNER JOIN tbl_loans a2 ON a2.branch_id = a1.branch_id
	GROUP BY a1.branch_name, a2.branch_id
;

/* stored proc 6 */

SELECT a1.borrower_name, a1.borrower_address, COUNT (a2.card_number) AS "# of books checked out"
	FROM tbl_borrower a1
	INNER JOIN tbl_loans a2 On a2.card_number = a1.card_number
	GROUP BY a2.card_number, a1.borrower_name, a1.borrower_address
	HAVING COUNT (*) > 5
	
;

/*stored proc 7*/

SELECT a1.book_title, COUNT (a2.No_Of_Copies) AS "copies"
	FROM tbl_book a1
	INNER JOIN tbl_copies a2 ON a2.book_id = a1.book_id
	INNER JOIN tbl_author a3 ON a3.book_id = a1.book_id
	WHERE a3.author_name = 'stephen king'
	GROUP BY a1.book_title, a2.No_Of_Copies, a2.branch_id
	HAVING branch_id = 2 
;


