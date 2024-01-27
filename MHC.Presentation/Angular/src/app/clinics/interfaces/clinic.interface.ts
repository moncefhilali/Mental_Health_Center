export interface Clinic {
  name: string;
  status: string;
  reviews: number;
  link: string;
  image: string | null;
  clinicType: {
    name: string;
  };
}
