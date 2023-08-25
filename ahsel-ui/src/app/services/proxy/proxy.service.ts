import { Injectable } from '@angular/core';
import { Observable, catchError } from 'rxjs';
import { environment } from 'src/environment/environment';
import { Get, Post } from './models';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ProxyService {
  constructor(private http: HttpClient) {}

  public post(post: Post): Observable<any> {
    return this.http.post<any>(
      `${environment.apiUrl}/api/${post.url}`,
      post.body,
      {
        headers: {
          'Content-Type': 'application/json',
        },
        params: post.params,
      }
    );
  }

  public async get(get: Get): Promise<Observable<any>> {
    return this.http.get<any>(`${environment.apiUrl}/api/${get.url}`, {
      headers: {
        'Content-Type': 'application/json',
      },
      params: get.params,
    });
  }
}
