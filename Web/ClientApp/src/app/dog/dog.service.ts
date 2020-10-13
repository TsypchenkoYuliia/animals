import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dog } from './dog';
import { DogComponent } from './dog.component';

@Injectable({
  providedIn: 'root'
})
export class DogService {

  constructor(private httpClient: HttpClient) {

  }

  url: string = "api/dog";

  get(): Observable<Dog[]> {
    return this.httpClient.get<Dog[]>(this.url);
  }

  post(dog: Dog, comp: DogComponent) {
    return this.httpClient.post(this.url, dog).subscribe(res => {
      comp.ngOnInit();
    });
  }
}
