   M S B A M L   `   `   `  ����H  DFragrantWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FragrantWorld.PagesFragrantWorld.Pages  5      %    FragrantWorld.Pages.ManagerPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FragrantWorld.Pages     5        N� Title$  ManagerPage��5	       N� 
FontFamily$ Comic Sans MS)�6   .��5      ]� .+�5   
   ]� $��Right=�6   $	��Top=�60   .+�5      �� -   5        $��userInfoTextBlock��5      $��10, 0q�61   �� 5      -   5        $��exitSystemButton��5      $$��Выйти из системы��6-   6H   5      ]� 5   
   $	��Top=�6   .+�5      �� -   5        $��sortProductsComboBox��5      .@�5      �� $#��По возврастанию��6   �� 5      $��По убыванию��6   5      �� 5      -   5        $��discountRangeComboBox��5      .@�5      �� $��Все диапазоны��6   �� 5      $��0-9,99%��6   �� 5      $��	10-14,99%��6   �� 5      $��15% и более��6   5      � 5      .+�5      �� -   5        $��searchTextBox��5      $	��470��6W   �� 5      -   5        $��hintSearchTextBlock��5      $��
Поиск��67    J� IsHitTestVisible$ False��6D   5      �� 5      -   5        $��countProductsTextBlock��5      $��Right=�66   5       �� 5!   
   -   5        $��showOrderButton��5!      $!��Показать заказ��6(   $y�	Collapsed=�6A   $	��Top=�6v   �� 5"   
   -	   5        $��editOrderButton��5"      $-��'Редактировать заказы��6(   $��20��6e   $��Bottom=�6q   �� 5#   
   $
��Auto=�6   $
��Auto��6:   $	��Top=�6H   .��5$      �� -
   5        $��productsListBox��5$      ��5%      �� 5&      .R�5'      �� $��1q�6!   
���   �$��5,0,0,0q�6I    �� Padding$ 3q�6Z   ._�5(      �� $	��730��6)    � ContextMenu 5)   "   �� 5*   &   .@�5+   *   m� $��addOrderMenuItem��63   -   5        $&�� Добавить к заказу��5+   K   6f   5,   '    � 	Resources 5.   "    �� 
TargetType �� Property �� Value��%\   '��       �� 5/   &   " ��6,   .�50   *   ��  � �� 6G   �� *Color+51   '   52   #   .+�53   "   �� $
��Bold"�6B   ��6,   �� *Name+6B   �� 54   "   ��6,   �� *Description+�� 55   "   ��6,   �� 	 �� StringFormat$%	 Производитель: {0}��
 �� Path$
 Manufacturer�]� 56   "   .+�57   &   �� $��
Цена: ��60   �� 58   &   $��Strikethrough{�6O   ��60   �� *CostConverter+6O   �� 59   &   $�� ��60   �� 5:   &   ��60   �� $	 {0:0.00} руб��$
 CostWithDiscount��� 5;   &   $��Right=�6j    �� TextAlignment$ Right=�6�   ��60   �� $
	 {0}%��$
 DiscountAmount�6�   5<   #   5=      5>      5?      5A      5B      5C      5D      