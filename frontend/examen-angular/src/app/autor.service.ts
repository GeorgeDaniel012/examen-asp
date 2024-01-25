import { Inject, Injectable } from '@angular/core';
import { HttpBackend, HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { Autor } from './autor';
import { Editura } from './editura';

@Injectable({
    providedIn: 'root'
})
export class AutorService{
    constructor(private http: HttpClient){}
    public getUrl: string = "https://localhost:7010/api/Autor";
    public postUrl: string = "https://localhost:7010/api/Autor";

    public getAutori(): Observable<any> {
        return this.http.get<any>(this.getUrl);
    }

    public addAutor(autor: Autor): Observable<any> {
        return this.http.post<any>(this.postUrl, autor);
    } 
    
}