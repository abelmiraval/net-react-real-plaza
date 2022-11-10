import { ChangeEvent, createContext } from 'react';
import { Product, ProductState } from '../interfaces/interfaces';

export type ProductContextProps = {
	productState: ProductState;
	handleChangeSelect: (e: ChangeEvent<HTMLSelectElement>) => void;
	handleChangeInput: (e: ChangeEvent<HTMLInputElement>) => void;
	getAllProducts: (orderBy: string, price: number, page: number) => Promise<void>;
	nextPage: () => void;
	prevPage: () => void;
};

export const ProductContext = createContext<ProductContextProps>({} as ProductContextProps);
