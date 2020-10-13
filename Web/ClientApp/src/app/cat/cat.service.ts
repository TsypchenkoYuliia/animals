import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Cat } from './cat';
import { CatComponent } from './cat.component';

@Injectable({
  providedIn: 'root'
})
export class CatService {

  constructor(private httpClient: HttpClient) { }

  url: string = "api/cat";

  get(): Observable<Cat[]> {
    return this.httpClient.get<Cat[]>(this.url);
  }

  post(cat: Cat, comp:CatComponent) {
    return this.httpClient.post(this.url, cat).subscribe(res => {
      comp.ngOnInit();
    });
  }

  

}

