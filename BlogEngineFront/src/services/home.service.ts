import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { url_api } from "src/app/app-constants";
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IPost } from 'src/components/post/post.class';
import { Post } from 'src/models/post.model';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private http: HttpClient,
              private router: Router) { }

  async getPost(): Promise<Observable<IPost[]>> {
    return this.http.get<IPost[]>(`${url_api}/api/Posts`)
  }

  async DeletePost(id: string){
    return await this.http.delete(`${url_api}/api/Posts/${id}`).subscribe();
  }
}
