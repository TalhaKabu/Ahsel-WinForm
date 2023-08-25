import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Get, Post } from '../proxy/models';
import { ProxyService } from '../proxy/proxy.service';
import { Client, ClientGroupDto, PaymentDto, Project } from './models';

@Injectable({
  providedIn: 'root',
})
export class GeneralService {
  private baseUrl = 'General';

  constructor(private proxyService: ProxyService) {}

  async getProjectList(): Promise<Observable<Project[]>> {
    var get: Get = {
      url: this.baseUrl + '/get-project-list',
    };
    return await this.proxyService.get(get);
  }

  async getClientList(projectRef: number): Promise<Observable<Client[]>> {
    var get: Get = {
      url: this.baseUrl + '/get-client-list',
      params: { projectRef: projectRef },
    };
    return await this.proxyService.get(get);
  }

  async getPaymentList(projectRef: number): Promise<Observable<PaymentDto[]>> {
    var get: Get = {
      url: this.baseUrl + '/get-payment-list',
      params: { projectRef: projectRef },
    };
    return await this.proxyService.get(get);
  }

  async getGroupedPaymentList(projectRef: number): Promise<Observable<ClientGroupDto[]>> {
    var get: Get = {
      url: this.baseUrl + '/get-grouped-payment-list',
      params: { projectRef: projectRef },
    };
    return await this.proxyService.get(get);
  }
}
