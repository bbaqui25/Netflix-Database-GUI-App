# Netflix Database Application using N-Tier Design

#### Implemented Data Access and Business tiers using C#, ADO.NET, and the dynamic execution of hand-written SQL queries.

###### View the results by running the program on Visual Studio.

#### N-Tier Design
![netflix](https://user-images.githubusercontent.com/38767320/43794866-44292af8-9a45-11e8-9ea3-06d7aa762ce3.png)

Here’s a summary of what each tier does: 
 
1. Presentation: interacts with the user 
2. Business:  supports the security, business rules, and data processing needed by this  particular application.  [ What’s a business rule?  Imagine a sales app; there  would be rules about how to charge sales tax, who gets discounts, etc. ] 
3. Data Access: interface between business tier and data store — the data access tier does not  manage nor store data, it only facilitates access to the data 
4. Data Store: actual data repository
