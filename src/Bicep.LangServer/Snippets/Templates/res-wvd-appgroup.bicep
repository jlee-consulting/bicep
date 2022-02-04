﻿// WVD AppGroup
resource /*${1:applicationGroup}*/applicationGroup 'Microsoft.DesktopVirtualization/applicationgroups@2019-12-10-preview' = {
  name: /*${2:'name'}*/'name'
  location: /*${3:location}*/'location'
  properties: {
    friendlyName: /*${4:'friendlyName'}*/'friendlyName'
    applicationGroupType: /*${5|'Desktop','RemoteApp'|}*/'Desktop'
    hostPoolArmPath: /*${6:'desktopVirtualizationHostPools.id'}*/'desktopVirtualizationHostPools.id'
  }
}
