import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Get, Post } from '../proxy/models';
import { ProxyService } from '../proxy/proxy.service';
import { ProjectDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class GeneralService {
  private baseUrl = 'General';

  constructor(private proxyService: ProxyService) {}

  getProjectList(): Observable<ProjectDto[]> {
    var get: Get = {
      url: this.baseUrl + '/get-project-list',
    };
    return this.proxyService.get(get);
  }

  getClientList(projectRef: number): Observable<any> {
    var get: Get = {
      url: this.baseUrl + '/get-client-list',
      params: { projectRef: projectRef },
    };
    return this.proxyService.get(get);
  }
}
