// Type definitions for ag-grid v18.1.2
// Project: http://www.ag-grid.com/
// Definitions by: Niall Crosby <https://github.com/ag-grid/>
import { Promise } from '../utils';
export declare class TabbedLayout {
    private eGui;
    private eHeader;
    private eBody;
    private params;
    private afterAttachedParams;
    private static TEMPLATE;
    private items;
    private activeItem;
    constructor(params: TabbedLayoutParams);
    setAfterAttachedParams(params: any): void;
    getMinWidth(): number;
    showFirstItem(): void;
    private addItem(item);
    showItem(tabbedItem: TabbedItem): void;
    private showItemWrapper(wrapper);
    getGui(): HTMLElement;
}
export interface TabbedLayoutParams {
    items: TabbedItem[];
    cssClass?: string;
    onItemClicked?: Function;
    onActiveItemClicked?: Function;
}
export interface TabbedItem {
    title: Element;
    bodyPromise: Promise<HTMLElement>;
    name: string;
    afterAttachedCallback?: Function;
}
