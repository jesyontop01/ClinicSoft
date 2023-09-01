import { Injectable, Directive } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { AccountHeadModel } from "../shared/account-head.model";

@Injectable()
export class AccountHeadDLService {
    public options =  {
        headers: new HttpHeaders({ 'Content-Type': 'application/x-www-form-urlencoded' })};
   constructor(public http: HttpClient) { }
    //GET
    public GetAccountHeadList() {
        return this.http.get<any>("/clinicsoft/api/InventorySettings?reqType=AccountHeadList");
    }
    public GetAccountHead() {
        return this.http.get<any>("/clinicsoft/api/InventorySettings?reqType=GetAccountHead");
    }



    //POST
    public PostAccountHead(CurrentAccountHead) {
        let data = JSON.stringify(CurrentAccountHead);
        return this.http.post<any>("/clinicsoft/api/InventorySettings?reqType=AddAccountHead", data, this.options);
    }



    //PUT
    public PutAccountHead(accounthead) {
        let data = JSON.stringify(accounthead);
        return this.http.put<any>("/clinicsoft/api/InventorySettings?reqType=UpdateAccountHead", accounthead, this.options);
    }
}