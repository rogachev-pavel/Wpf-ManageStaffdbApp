   M S B A M L   `   `   `  ����K  GManageStaffDBapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ManageStaffDBappManageStaffDBapp  5   	   &     ManageStaffDBapp.View.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ManageStaffDBapp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   .@�5      �� -   5        $��UsersTab��5      ��5      �� 5      $��Staff��6    .��5      �� -   5         ��Name$ ViewAllUsers��5      ��61   �� *
AllUsers+ �� View 5      �� 5      .P�5      �� $
��Name��6-    �� DisplayMemberBinding 5   -   ��  �� Path$
 Name��� 5      $��SurName��6-    5   -   �� $ SurName��� 5      $��Phone��6-    5   -   �� $ Phone��� 5      $��Salary��6-    5   -   �� $ UserPosition.Salary��� 5      $��Position��6-    5   -   �� $ UserPosition.Name��� 5       $��
Department��6-    5!   -   �� $* $UserPosition.PositionDepartment.Name�5"      5$      5%      �� 5&      -   5        $��PositionTab��5&      ��5'      �� 5(      $��Position��6    .��5*      �� -   5        $ ViewAllPositions��5*      ��65   �� *AllPositions+ 5+      �� 5,      .P�5-      �� $
��Name��6-    5.   -   �� $
 Name��� 5/      $��Salary��6-    50   -   �� $ Salary��� 51      $��Count of staffs��6-    52   -   �� $ PositionUsers.Count��� 53      $��
Max number��6-    54   -   �� $ 	MaxNumber��� 55      $��
Department��6-    56   -   �� $ PositionDepartment.Name�57      59      5:      �� 5;      -   5        $��DepartmensTab��5;      ��5<      �� 5=      $��
Departmens��6    .��5?      �� -   5        $ ViewAllDepartmens��5?      ��66   �� *AllDepartments+ 5@      �� 5A      .P�5B      �� $
��Name��6-    5C   -   �� $
 Name��� 5D      $��Count of positions��6-    5E   -   �� $ DepartmentPositions.Count�5F      5H      5I      5J      �� 5K   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5L      �� $#��Новый сотрудник��6   ��6/   �� *OpenAddNewUserWind+6X   �� 5M      $��Новая позиция��6   ��6-   �� *OpenAddNewPositionWind+6Z   �� 5N      $'��!Новый департамент��6   ��61   �� *OpenAddNewDepartmentWind+6`   5O      5P      5Q      