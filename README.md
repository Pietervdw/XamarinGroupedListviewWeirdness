# XamarinGroupedListviewWeirdness

To reproduce the error, start the app:

1. Tap click on the "Go to movies" button.
2. Scroll all the way to the bottom of the list
3. Scroll all the way back to the top
4. Tap on the top left back arrow "< Main Page" to go back to the first page.

See https://github.com/xamarin/Xamarin.Forms/issues/6888 for a workaround. Solution is to add a Group Header Template to the ListView e.g.

```xaml
<ListView.GroupHeaderTemplate>
            <DataTemplate>
                <ViewCell Height="40">
                    <StackLayout Orientation="Horizontal"
                                 BackgroundColor="#081c24"
                                 VerticalOptions="FillAndExpand">
                        <Label Text="{Binding DateLong}"
                               TextColor="#01d277"
                               VerticalOptions="Center" />
                    </StackLayout>
                </ViewCell>
            </DataTemplate>
        </ListView.GroupHeaderTemplate>
```

Full ListView XAML:

```xaml
<ListView ItemsSource="{Binding MovieGroups}" x:Name="ListviewMovies"
              IsGroupingEnabled="True" CachingStrategy="RecycleElementAndDataTemplate"
              GroupDisplayBinding="{Binding DateLong}">
        <ListView.Behaviors>

            <prism:EventToCommandBehavior EventName="ItemTapped" 
                                          Command="{Binding GenreTappedCommand}"
                                          EventArgsConverter="{StaticResource ItemTappedEventArgsConverter}"/>


            <prism:EventToCommandBehavior EventName="ItemAppearing" 
                                          Command="{Binding ItemAppearingCommand}"
                                          EventArgsConverter="{StaticResource MovieItemVisibilityEventArgsConverter}"/>

        </ListView.Behaviors>

        <ListView.GroupHeaderTemplate>
            <DataTemplate>
                <ViewCell Height="40">
                    <StackLayout Orientation="Horizontal"
                                 BackgroundColor="#081c24"
                                 VerticalOptions="FillAndExpand">
                        <Label Text="{Binding DateLong}"
                               TextColor="#01d277"
                               VerticalOptions="Center" />
                    </StackLayout>
                </ViewCell>
            </DataTemplate>
        </ListView.GroupHeaderTemplate>

        <ListView.ItemTemplate>
            <DataTemplate>
                <ImageCell ImageSource="{Binding Poster}" Text="{Binding Title}" Detail="{Binding Overview}" />
            </DataTemplate>
        </ListView.ItemTemplate>

        <ListView.Footer>
            <Grid IsVisible="{Binding IsBusy}">
                <Grid.Triggers>
                    <Trigger TargetType="Grid" Property="IsVisible" Value="False">
                        <Setter Property="HeightRequest" Value="0" />
                    </Trigger>
                </Grid.Triggers>
                <ActivityIndicator IsRunning="{Binding IsBusy}" VerticalOptions="Center" HorizontalOptions="Center"/>
            </Grid>
        </ListView.Footer>

    </ListView>
```
