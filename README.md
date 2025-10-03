## 📖 About

The **Dynamics CRM Bulk Data Creator** is an XrmToolBox plugin designed to help you create large volumes of **realistic, customizable test data** directly in your **Dynamics 365 / Dataverse** environment.

Instead of manually creating sample records or importing static spreadsheets, this tool lets you define **data generation templates** using a mix of:

- **Bogus Faker library tokens** — for realistic names, addresses, phone numbers, dates, and more.
- **Custom mock tokens** — for specialized formats like sequences, lookups, and controlled random values.

---

### 💡 Why Use It?
Manually preparing test data can be **time-consuming** and **error-prone**.  
This tool automates the process, ensuring **consistency** and **variability** at scale.  
It’s ideal for:

- **Testing**: Validate workflows, business rules, and custom plugins under realistic data conditions.
- **Prototyping**: Build and preview features with pre-filled datasets before real data is available.
- **Demonstrations & Training**: Showcase system capabilities with clean, believable records.

---

### ⚙ How It Works
1. **Select the Target Entity**  
   Choose the entity where you want to generate records (e.g., Contact, Account, Custom Entities).

2. **Select the Entity fields**  
   Choose the fields where you want to populate the data (e.g., fullname, address, etc.).

3. **Define Field Expression**  
   Assign a expression to each field.  

4. **Set Record Count**  
   Decide how many records you want to generate.

5. **Preview Data**  
   See how the final data would look like before generating.

6. **Generate Data**  
   The tool will create records directly in your CRM with the chosen patterns.

---

### 🧩 Key Features
- ✅ Supports **all Bogus Faker tokens**
- ✅ Includes **custom mock tokens** for advanced scenarios
- ✅ Handles **relationships** via lookup tokens
- ✅ Bulk insert for thousands of records
- ✅ Real-time preview before creation

---

With this approach, you can have **thousands of diverse, meaningful records** ready in minutes — without writing a single line of code.
