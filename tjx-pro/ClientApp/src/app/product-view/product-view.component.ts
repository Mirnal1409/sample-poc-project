import { Component, OnInit } from '@angular/core';
import { CurrencyService } from '../currency.service';

@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
  products: any[];
  countries: any[];
  selectedCountry: string = 'GBP';
  originalCountry: string = 'GBP';
  exchangeRate: any;
  loading: boolean = true;

  constructor(private currencyService: CurrencyService) { }

  ngOnInit(): void {
    this.loadProducts();
    this.loadCountries();
  }

  loadProducts(): void {
    this.loading = true;
    this.currencyService.getProducts().subscribe(
      (products) => {
        this.products = products;
        this.loading = false;
      },
      (error) => {
        console.error('Error loading products', error);
        this.loading = false;
      }
    );
  }

  loadCountries(): void {
    this.loading = true;
    this.currencyService.getCountries().subscribe(
      (countries) => {
        this.countries = countries;
        this.loading = false;
      },
      (error) => {
        console.error('Error loading countries', error);
        this.loading = false;
      }
    );
  }

  async onCountryChange(): Promise<void> {
    await this.updateProductPrices();
  }

  async updateProductPrices(): Promise<void> {
    this.loading = true;

    try {
      this.exchangeRate = await this.currencyService.getExchangeRate(this.originalCountry, this.selectedCountry).toPromise();

      console.log(this.exchangeRate);

      this.products.forEach((product) => {
        product.price = product.price * this.exchangeRate.amount;
      });

      console.log(this.products);

      this.originalCountry = this.selectedCountry;
    } catch (error) {
      console.error('Error updating product prices', error);
    } finally {
      this.loading = false;
    }
  }
}
