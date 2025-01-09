# **MySchoolScoreManagementUI**

## **Overview**
This project implements a school score management system using a hierarchical data structure. It models school years, classrooms, and students while leveraging **DevExpress TreeListControl** for visual representation. The system employs **observable collections** and data binding to ensure real-time synchronization between data and UI. Additionally, **DevExpress** components significantly enhance the user interface by providing advanced grid, tree view, and data visualization features.

---

## **Features**
- **Hierarchical data structure**:
  - `SchoolYear` contains multiple `ClassRoom` objects.
  - Each `ClassRoom` contains multiple `Student` objects.
- **Dynamic tree structure**:
  - Uses `TreeNode` and `TreeChildSelector` for displaying data hierarchically in a tree view.
  - Automatically updates the tree when school years, classrooms, or students are added or removed.
- **Observable data collections**:
  - Automatically updates the UI when data changes.
- **DevExpress Integration**:
  - Uses **TreeListControl** for hierarchical data visualization.
  - Provides advanced sorting, filtering, and data management features.
  - Enhances user experience with customizable styles and built-in theming.

---

## **Core Classes**

### **1. ModelManger**
- Central class for managing all data.
- Provides methods to add school years, classrooms, and students.
- Automatically updates the tree structure when data changes.
- Uses `ObservableCollection` for real-time UI updates.
- Handles `CollectionChanged` events for dynamic updates of the tree structure.

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
- Methods:
  - `AddSubNode`: Adds a child node.
  - `RemoveSubNode`: Removes a child node.

### **6. TreeChildSelector**
- Implements `IChildNodesSelector` for DevExpress TreeListControl.
- Defines the child node selection logic for tree visualization.

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
