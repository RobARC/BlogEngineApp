import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPost } from 'src/components/post/post.class';
import { url_api } from 'src/app/app-constants';
import { Post } from 'src/models/post.model';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  constructor(private http: HttpClient) { }

  async getPosts(id: string) {
    return await this.http.get<IPost[]>(`${url_api}/api/Posts/${id}`)
  }
  async SendPost(data: IPost){
      return await this.http.post(`${url_api}/api/Posts`, data,).subscribe();
  }
  async UpdatePost(id: string, data: IPost){
    return await this.http.put(`${url_api}/api/Posts/${id}`, data).subscribe();
  }
 
}
