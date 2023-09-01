import { Injectable, Directive } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { _ } from 'ag-grid-community';

@Injectable()
export class LabLISDLService {
    public http: HttpClient;
    public options = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
    constructor(_http: HttpClient) {
        this.http = _http;
    }

    GetAllLISMasterData() {
        return this.http.get<any>("/clinicsoft/api/LIS/GetAllLISMasterData", this.options);
    }

    GetAllLISMappedData() {
        return this.http.get<any>("/clinicsoft/api/LIS/GetAllMappedData", this.options);
    }

    GetAllLISNotMappedDataByMachineId(id: number, selectedMapId: number) {
        return this.http.get<any>("/clinicsoft/api/LIS/GetAllNotMappedDataByMachineId?id=" + id + "&slectedMapId=" + selectedMapId, this.options);
    }

    GetExistingMappingById(id: number) {
        return this.http.get<any>("/clinicsoft/api/LIS/GetExistingMappingById?id=" + id, this.options);
    }

    GetAllMachinesMaster() {
        return this.http.get<any>("/clinicsoft/api/LIS/GetAllMachines", this.options);
    }

    GetAllMachineResult(id: number) {
        return this.http.get<any>("/clinicsoft/api/LIS/GetAllMachineResult?machineId=" + id, this.options);
    }

    public AddUpdateLisMapping(data) {
        return this.http.post<any>("/clinicsoft/api/LIS/AddUpdateNewMapping", data, this.options);
    }

    public AddLisDataToResult(data) {
        return this.http.post<any>("/clinicsoft/api/LIS/AddLisDataToResult", data, this.options);
    }

    public RemoveLisMapping(id: number) {
        return this.http.delete<any>("/clinicsoft/api/LIS/RemoveMapping?id=" + id, this.options);
    }
}