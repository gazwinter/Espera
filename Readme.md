# Espera

## Overview

Espera is a portable music player written in C# with WPF as frontend technology.

It is designed as party-player, as it offers features such as locking the player and allowing only to add a certain
amount of songs to the playlist at a certain time, or adding music from YouTube to the playlist and streaming the 
audio track of the video directly.

## Features

### Party-Lock (partially implemented)

Espera allows to lock itself, this comes handy on parties, where the guests shouldn't be able to change the volume or 
stop the music, but still be able to add songs to the playlist.

### YouTube

Espera can search songs at YouTube, add them to the playlist and stream the audio track. 

This function requires the VLC media player to be installed, as it streams the YouTube audio track in the background 
without opening the VLC media player itself. (Sadly I found no other way to stream from YouTube without a depency to VLC)

### Mp3-players & removable devices

Espera has built-in support for adding music from MP3-players and other removable devices to the playlist.
The music that is added to the playlist will be automatically cached on the computer, so that the devices can be removed
without affecting the playback.

### Metro-Style

Espera uses [MahApps.Metro](http://github.com/MahApps/MahApps.Metro) for  theming. This gives Espera a beautiful and 
very clean look.

## Requirements

 - .NET Framework 4.0
 - VLC media player >= 2.0

## Development
 
Espera is currently in a verly early stage of development and has to be compiled from the source code, but it already 
can play songs from the local hard drive or from YouTube.

## Screenshot

![Screenshot](http://flagbug.github.com/espera/screenshot.jpg)