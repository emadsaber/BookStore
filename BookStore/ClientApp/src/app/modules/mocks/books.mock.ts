import { Observable } from 'rxjs';
import { BookDto } from '../models/dtos/BookDto';
import { of } from 'rxjs'
import { ApiResponse } from '../models/bases/ApiResponse';
import { PagedList } from '../models/bases/PagedList';

export class BooksMocks {
    static mocked: BookDto[] =
        [
            {
                "id": "99069323-2050-49ea-b74e-00d5ab89d2fc",
                "title": "Learning JavaScript Design Patterns",
                "subtitle": "A JavaScript and jQuery Developer's Guide",
                "description": "With Learning JavaScript Design Patterns, you'll learn how to write beautiful, structured, and maintainable JavaScript by applying classical and modern design patterns to the language. If you want to keep your code efficient, more manageable, and up-to-date with the latest best practices, this book is for you.",
                "rating": 4.5,
                "isbn": "9781449331818",
                "publisher": "O'Reilly Media",
                "publishedAt": "2012-07-01T00:00:00",
                "website": "http://www.addyosmani.com/resources/essentialjsdesignpatterns/book/",
                "pagesCount": 254,
                "authors": [],
                "reviews": []
            },
            {
                "id": "9a9e2242-8f65-4053-95b3-3c262484de02",
                "title": "You Don't Know JS",
                "subtitle": "ES6 & Beyond",
                "description": "No matter how much experience you have with JavaScript, odds are you don’t fully understand the language. As part of the 'You Don’t Know JS' series, this compact guide focuses on new features available in ECMAScript 6 (ES6), the latest version of the standard upon which JavaScript is built.",
                "rating": 2.5,
                "isbn": "9781491904244",
                "publisher": "O'Reilly Media",
                "publishedAt": "2015-12-27T00:00:00",
                "website": "https://github.com/getify/You-Dont-Know-JS/tree/master/es6%20&%20beyond",
                "pagesCount": 278,
                "authors": [],
                "reviews": []
            },
            {
                "id": "0db4295e-29f7-417c-958b-545c5a5e4ad1",
                "title": "Programming JavaScript Applications",
                "subtitle": "Robust Web Architecture with Node, HTML5, and Modern JS Libraries",
                "description": "Take advantage of JavaScript's power to build robust web-scale or enterprise applications that are easy to extend and maintain. By applying the design patterns outlined in this practical book, experienced JavaScript developers will learn how to write flexible and resilient code that's easier-yes, easier-to work with as your code base grows.",
                "rating": 4.6,
                "isbn": "9781491950296",
                "publisher": "O'Reilly Media",
                "publishedAt": "2014-07-01T00:00:00",
                "website": "http://chimera.labs.oreilly.com/books/1234000000262/index.html",
                "pagesCount": 254,
                "authors": [],
                "reviews": []
            },
            {
                "id": "d771c6d6-b5bc-4fd9-9399-59403124c5c9",
                "title": "Eloquent JavaScript, Second Edition",
                "subtitle": "A Modern Introduction to Programming",
                "description": "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based games. Though simple for beginners to pick up and play with, JavaScript is a flexible, complex language that you can use to build full-scale applications.",
                "rating": 3.5,
                "isbn": "9781593275846",
                "publisher": "No Starch Press",
                "publishedAt": "2014-12-14T00:00:00",
                "website": "http://eloquentjavascript.net/",
                "pagesCount": 472,
                "authors": [],
                "reviews": []
            },
            {
                "id": "81bc9cd4-28ac-43e3-8116-8cdd728ba274",
                "title": "Git Pocket Guide",
                "subtitle": "A Working Introduction",
                "description": "This pocket guide is the perfect on-the-job companion to Git, the distributed version control system. It provides a compact, readable introduction to Git for new users, as well as a reference to common commands and procedures for those of you with Git experience.",
                "rating": 4.1,
                "isbn": "9781449325862",
                "publisher": "O'Reilly Media",
                "publishedAt": "2013-08-02T00:00:00",
                "website": "http://chimera.labs.oreilly.com/books/1230000000561/index.html",
                "pagesCount": 234,
                "authors": [],
                "reviews": []
            },
            {
                "id": "8fca3674-b6a0-4548-8d77-97cd50d7b863",
                "title": "Designing Evolvable Web APIs with ASP.NET",
                "subtitle": "Harnessing the Power of the Web",
                "description": "Design and build Web APIs for a broad range of clients—including browsers and mobile devices—that can adapt to change over time. This practical, hands-on guide takes you through the theory and tools you need to build evolvable HTTP services with Microsoft’s ASP.NET Web API framework. In the process, you’ll learn how design and implement a real-world Web API.",
                "rating": 4.8,
                "isbn": "9781449337711",
                "publisher": "O'Reilly Media",
                "publishedAt": "2014-04-07T00:00:00",
                "website": "http://chimera.labs.oreilly.com/books/1234000001708/index.html",
                "pagesCount": 538,
                "authors": [],
                "reviews": []
            },
            {
                "id": "2cd76904-bed1-4802-950f-a5878c733594",
                "title": "Understanding ECMAScript 6",
                "subtitle": "The Definitive Guide for JavaScript Developers",
                "description": "ECMAScript 6 represents the biggest update to the core of JavaScript in the history of the language. In Understanding ECMAScript 6, expert developer Nicholas C. Zakas provides a complete guide to the object types, syntax, and other exciting changes that ECMAScript 6 brings to JavaScript.",
                "rating": 2.5,
                "isbn": "9781593277574",
                "publisher": "No Starch Press",
                "publishedAt": "2016-09-03T00:00:00",
                "website": "https://leanpub.com/understandinges6/read",
                "pagesCount": 352,
                "authors": [],
                "reviews": []
            },
            {
                "id": "2e13d6ad-6b6d-4520-9f39-ed9065c2ac5d",
                "title": "Speaking JavaScript",
                "subtitle": "An In-Depth Guide for Programmers",
                "description": "Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who once found himself in the same position.",
                "rating": 3.7,
                "isbn": "9781449365035",
                "publisher": "O'Reilly Media",
                "publishedAt": "2014-02-01T00:00:00",
                "website": "http://speakingjs.com/",
                "pagesCount": 460,
                "authors": [],
                "reviews": []
            }
        ];

    static getBooksMock(): Observable<ApiResponse<PagedList<BookDto>>> {

        let res: ApiResponse<PagedList<BookDto>> = {
            "data": {
                "pageNumber": 1,
                "pageSize": 10,
                "pagesCount": 1,
                "totalCount": 8,
                "pagedData": this.mocked
            },
            success: true,
            errors: null
        };

        return of(res);
    }
    static getBookMock(bookId: string): Observable<ApiResponse<BookDto>> {
        let book = this.mocked.find(x => x.id === bookId);
        let res: ApiResponse<BookDto> = {
            data: book,
            errors: null,
            success: true
        };

        return of(res);
    }
}
