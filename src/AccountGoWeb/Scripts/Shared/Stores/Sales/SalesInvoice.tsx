﻿import SalesInvoiceLine from "./SalesInvoiceLine";

//interface ISalesInvoice {
//    id;
//    customerId;
//    invoiceDate;
//    paymentTermId;
//    referenceNo;
//    salesInvoiceLines: SalesInvoiceLine[];
//}

export default class SalesInvoice {
    id: number;
    fromSalesOrderId: any;
    customerId: number;
    invoiceDate: Date;
    paymentTermId: number;
    referenceNo: string;
    salesInvoiceLines: SalesInvoiceLine[] = [];
}