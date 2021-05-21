USE [BookStore]
GO

INSERT INTO [dbo].[Books]
([ISBN],[Title],[Subtitle],[PublishedAt],[Publisher],[Rating],[PagesCount],
[Description],[Website],[CreatedBy])
VALUES
(
'9781593275846',
'Eloquent JavaScript, Second Edition',
'A Modern Introduction to Programming',
'2014-12-14T00:00:00.000Z',
'No Starch Press',
3.5,
472,
'JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based games. Though simple for beginners to pick up and play with, JavaScript is a flexible, complex language that you can use to build full-scale applications.',
'http://eloquentjavascript.net/', 
'admin'),
(
'9781449331818',
'Learning JavaScript Design Patterns',
'A JavaScript and jQuery Developer''s Guide',
'2012-07-01T00:00:00.000Z',
'O''Reilly Media',
4.5,
254,
'With Learning JavaScript Design Patterns, you''ll learn how to write beautiful, structured, and maintainable JavaScript by applying classical and modern design patterns to the language. If you want to keep your code efficient, more manageable, and up-to-date with the latest best practices, this book is for you.',
'http://www.addyosmani.com/resources/essentialjsdesignpatterns/book/',
'admin'),
(
 '9781449365035',
 'Speaking JavaScript',
 'An In-Depth Guide for Programmers',
 '2014-02-01T00:00:00.000Z',
 'O''Reilly Media',
 3.7,
 460,
 'Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who once found himself in the same position.',
 'http://speakingjs.com/','admin'
 ),
 (
      '9781491950296',
      'Programming JavaScript Applications',
      'Robust Web Architecture with Node, HTML5, and Modern JS Libraries',
      '2014-07-01T00:00:00.000Z',
      'O''Reilly Media',
	  4.6,
      254,
      'Take advantage of JavaScript''s power to build robust web-scale or enterprise applications that are easy to extend and maintain. By applying the design patterns outlined in this practical book, experienced JavaScript developers will learn how to write flexible and resilient code that''s easier-yes, easier-to work with as your code base grows.',
      'http://chimera.labs.oreilly.com/books/1234000000262/index.html'
	  ,'admin'
    ),
    (
      '9781593277574',
      'Understanding ECMAScript 6',
      'The Definitive Guide for JavaScript Developers',
      '2016-09-03T00:00:00.000Z',
      'No Starch Press',
	  2.5,
      352,
      'ECMAScript 6 represents the biggest update to the core of JavaScript in the history of the language. In Understanding ECMAScript 6, expert developer Nicholas C. Zakas provides a complete guide to the object types, syntax, and other exciting changes that ECMAScript 6 brings to JavaScript.',
      'https://leanpub.com/understandinges6/read'
		,'admin'
),
    (
      '9781491904244',
      'You Don''t Know JS',
      'ES6 & Beyond',
      '2015-12-27T00:00:00.000Z',
      'O''Reilly Media',
      2.5,
	  278,
      'No matter how much experience you have with JavaScript, odds are you don’t fully understand the language. As part of the ''You Don’t Know JS'' series, this compact guide focuses on new features available in ECMAScript 6 (ES6), the latest version of the standard upon which JavaScript is built.',
      'https://github.com/getify/You-Dont-Know-JS/tree/master/es6%20&%20beyond'
	  ,'admin'
    ),
    (
      '9781449325862',
      'Git Pocket Guide',
      'A Working Introduction',
      '2013-08-02T00:00:00.000Z',
      'O''Reilly Media',
	  4.1,
      234,
      'This pocket guide is the perfect on-the-job companion to Git, the distributed version control system. It provides a compact, readable introduction to Git for new users, as well as a reference to common commands and procedures for those of you with Git experience.',
      'http://chimera.labs.oreilly.com/books/1230000000561/index.html'
	  ,'admin'
    ),
    (
      '9781449337711',
      'Designing Evolvable Web APIs with ASP.NET',
      'Harnessing the Power of the Web',
      '2014-04-07T00:00:00.000Z',
      'O''Reilly Media',
	  4.8,
      538,
      'Design and build Web APIs for a broad range of clients—including browsers and mobile devices—that can adapt to change over time. This practical, hands-on guide takes you through the theory and tools you need to build evolvable HTTP services with Microsoft’s ASP.NET Web API framework. In the process, you’ll learn how design and implement a real-world Web API.',
      'http://chimera.labs.oreilly.com/books/1234000001708/index.html'
	  ,'admin'
    )