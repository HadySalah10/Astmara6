   M S B A M L   `   `   `  ����C  ?Astmara6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Astmara6.Controls.Print_Data.Child"Astmara6.Controls.Print_Data.Child  5      #clr-namespace:Astmara6Astmara6  5      ;    5Astmara6.Controls.Print_Data.Child.UCIstimaraBDoctors   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Astmara6.Controls.Print_Data.Child     5      +Astmara6clr-namespace:Astmara6     5      -   5          � 	Resources  5
         Astmara6.Teachers   teachers  teachersViewSource �� Source �� Source  1   Astmara6.Branches  branches  branchesViewSource��%�   &	        &	      7   &	 B     &	 c     &	 v     7    5   
   6   �� 5   
    6:   �� *	_Teachers+8   ��5   
   	#FF3580BF��6%     5   
   6   �� 5   
    6:   �� *	_Branches+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ IstmaraB��5      $
��Left=�6%      AutoGenerateColumns .     
IsReadOnly . $	��327��6o      EnableRowVirtualization . $��RightToLeft=�6�   $��110,147,0,0q�6�   $	��Top=�6�   $	��652��6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6	  ��6�   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
الاسم��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6'   �� *Name+6P     5      $
 الدرجة��6A   $
 auto 6Q    6'   �� *Rank+6Q     5      $!
 النصب القانوني��6I   $
 auto 6a    6'   �� *HoursOfquerm+6a     5      $5
 /المواد التي يقوم بتدريسها��6D   $
 auto 6g    6'   �� *	Namesub+6g     5      $
 نظري��6E   $
 auto 6S    6'   �� *
Academic+6S     5      $
 عملي��6D   $
 auto 6R    6'   �� *	Virtual+6R     5      $
 تمارين��6F   $
 auto 6V    6'   �� *	Exprement+6V   5      �� 5   
   -   5         ��Name$ _TeachersComboBox��5       �� DisplayMemberPath$
 Name��6.   $��434,63,168,393q�6_    �� SelectedValuePath$ Id��6w   ��6G   �� ��5      �� 5       .R�5!      $� 5"      5$      �� 5%   
   $��حدد الدكتور ��6   $
��Left=�6'   $	��Top=�6B   $��
667,66,0,0q�6Z   ��5&      �� 5'       �� Color# �  6"   5)      �� 5*   
   $��
القسم��6   $
��Left=�6    $	��Top=�6;   $��
693,10,0,0q�6S   $��33��6g   $��44��6s   ��5+      �� 5,      # �  6"   5.      �� 5/   
   -   5        $ _BranchesComboBox��5/      $ TypeOfBranch��6.   $��492,10,168,441q�6�   $ Id��6�   $��33��6�   ��6O   �� # [ ��50      �� 51      .R�52      $� 53      55      �� 56   
   -   5         ��Name$ btnExportData��56      $��استخراح��6(   $
��Left=�6U   $��
10,442,0,0q�6p   $	��Top=�6�   $��95��6�   �� 57   
   -   5        $��اختر الكل��57      $
��Left=�6%   $��
11,382,0,0q�6@   $	��Top=�6T   $��94��6l   6w   59      5:      