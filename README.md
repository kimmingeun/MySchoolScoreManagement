# **MySchoolScoreManagementUI**

## **Overview**
This project implements a school score management system using a hierarchical data structure. The system models school years, classrooms, and students, and uses **DevExpress TreeListControl** for visual representation. It also utilizes **observable collections** and data binding to ensure real-time synchronization between the data and the UI.

---

## **Features**
- **Hierarchical data structure**:
  - `SchoolYear` contains multiple `ClassRoom` objects.
  - Each `ClassRoom` contains multiple `Student` objects.
- **Dynamic tree structure**:
  - Uses `TreeNode` and `TreeChildSelector` for displaying data hierarchically in a tree view.
- **Observable data collections**:
  - Automatically updates the UI when data changes.
- **Integration with DevExpress** for enhanced UI features.

---

## **Core Classes**

### **1. ModelManger**
- Central class for managing all data.
- Provides methods to add school years, classrooms, and students.
- Automatically updates the tree structure when data changes.
- Uses `ObservableCollection` for real-time UI updates.

### **2. SchoolYear**
- Represents a single school year.
- Contains a collection of `ClassRoom` objects.
- Methods:
  - `AddClassRoom`: Adds a new classroom to the school year.

### **3. ClassRoom**
- Represents a single classroom.
- Contains a collection of `Student` objects.
- Methods:
  - `AddStudent`: Adds a new student to the classroom.

### **4. Student**
- Represents a single student.
- Stores student scores for midterms and finals.
- Contains a reference to the associated `ClassRoom`.

### **5. TreeNode**
- Represents a node in the tree structure.
- Maintains a parent-child relationship for hierarchical data visualization.
- Supports selection and subnode management.

---

## **Setup Instructions**

### **1. Prerequisites**
- Visual Studio 2022 (or later).
- DevExpress WPF Controls (23.2 or compatible version).
- .NET Framework 4.7.2 or higher.

### **2. Installation**
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/MySchoolScoreManagementUI.git
